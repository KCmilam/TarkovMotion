using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Windows.Forms;

namespace TarkovMotion
{
    public class Settings
    {
        private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TarkovMotion", "Settings.xml");

        public bool LaunchProgramsOnstart { get; set; } = true;
        public string TarkovMonitorEXEPath { get; set; } = "";
        public string AITrackerEXEPath { get; set; } = "";  
        public string Browser { get; set; } = "Firefox";
        public Keys LeftLeanKey { get; set; } = Keys.Q;
        public Keys RightLeanKey { get; set; } = Keys.E;
        public double TriggerDistance { get; set; } = 6;
        public bool Mirrored { get; set; } = false;
        public bool ShoulderTransition { get; set; } = true;
        public Keys ShoulderTransitionKey { get; set; } = Keys.Divide;

        private static Settings _instance;
        
        public Settings() { }

        public static Settings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Open();
                }
                return _instance;
            }
        }

        public static void Save()
        {

            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            System.Xml.XmlTextWriter TextWriter = new System.Xml.XmlTextWriter(path, null);
            TextWriter.Formatting = System.Xml.Formatting.Indented;
            XmlSerializer Serializer = new XmlSerializer(typeof(Settings));
            try
            {
               Serializer.Serialize(TextWriter, _instance);
            }
            catch (Exception ex)
            {
                throw new NotSupportedException("Unable to save settings: " + Environment.NewLine + path + Environment.NewLine + ex.Message);
            }
            TextWriter.Close();
        }

        public static Settings Open()
        {
            if (!File.Exists(path))
            {
                return new Settings();
            }

            System.Xml.XmlTextReader TextReader = null;
            try
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(Settings));

                TextReader = new System.Xml.XmlTextReader(path);

                if (Serializer.CanDeserialize(TextReader))
                {
                    Settings OpenedProject = (Settings)Serializer.Deserialize(TextReader);
                    TextReader.Close();
                    return OpenedProject;
                }
                else
                {
                    TextReader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                TextReader.Close();
                throw new NotSupportedException("Unable to read settings file: " + Environment.NewLine + path + Environment.NewLine + ex.Message);
            }
        }
    }
}
