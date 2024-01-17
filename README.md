Uses AITracker for head tracking and maps the output to key binds that are read by Tarkov.  
The key binds can be configured, as well as the distance you want to lean to activate the key bind.  
Shoulder transition is also supported when leaning left.

![TarkovMotion](https://github.com/KCmilam/TarkovMotion/assets/42074461/cf857875-1024-4653-acff-766eba0704ea)

Example video of it in use: https://www.youtube.com/watch?v=9nJXhiv9HWU

**Setup Instructions**

1) Install AITracker (https://github.com/AIRLegend/aitrack).  Configure AITracker to use the correct camera.

2)  Run TarkovMotion.   Configure your key binds, set the desired lean distance, and run Tarkov.


**Notes**

* A resolution of 720p or higher is recommended for the webcam
* Sufficient lighting is need in the room for AITracker to track the face.
* The program only sends the keybinds when Escape From Tarkov is focused.
* It's suggested to sit center of screen and look at the center of the screen and click the "Recenter" button. This will set the base point that the app will use to calculate lean distance and trigger the key bind.
* AITracker outputs to the local IP address using UDP so it requests access to the local network.

