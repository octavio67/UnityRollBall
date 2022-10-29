# UnityRollBall

***UnityRollBall***

This project is about a Unity Game Tutorial called RollaBall with some modifications. 


The game consists of driving and making a ball jump to collect pickups.


The game has a main menu that allows you to play the full game consisting of two scenes or select and play only the second scene.


***REQUISITES*** ⚙️

[Microsoft Visual studio](https://visualstudio.microsoft.com/es/)


[Unity](https://unity.com/es)



***STARTING*** 🚀

- cd existing_folder

- git clone --branch main https://github.com/octavio67/UnityRollBall.git, them you get a 'UnityRollBall' folder that contains an Unity Project

- Open UnityHub and select "Open-add project from disk" to find and open your recent Unity Proyect upload from Git
![openUnity](https://user-images.githubusercontent.com/57419892/197755070-32a2d377-67e5-4d2f-a148-d13964edd221.JPG)

- Select File-Open Scene from menu and Select Scene Folder and then Menu. Run the unity project from your Unity Editor
![openUnity2](https://user-images.githubusercontent.com/57419892/197755741-f51cd36a-fb40-4f52-84a2-10c07b3bf01e.JPG)

***NOTES***

The scenes have a box collider on each wall to prevent the ball from going out of the plane.


The points counter is negative to indicate the pickups that remain to be collected.


The scene change from 1 to 2 is done by checking if the ball collides with a box collider placed at the scene exit and all pickups have been collected.


The game ends in scene 2 checking that all the pickups have been collected.


For the ball to jump, a plane is placed on top of each box that simulates a step with its corresponding label to check whether or not the ball is touching the plane to prevent it from jumping more than once when it is in the air.

***INGAME SCREENSHOTS***
![unityrun1](https://user-images.githubusercontent.com/57419892/197762320-5186a5ed-13a9-4939-92a7-712bf80e7e13.JPG)
![unityrun2](https://user-images.githubusercontent.com/57419892/197762369-3a4212c6-d928-4a3c-a074-b5b1e510eed2.JPG)
![unityrun3](https://user-images.githubusercontent.com/57419892/197762411-a62579d0-d500-407a-8510-41cac1d8c7d1.JPG)
