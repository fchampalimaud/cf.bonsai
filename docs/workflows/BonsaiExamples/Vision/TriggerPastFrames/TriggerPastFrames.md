# Trigger Past Frames

## Summary
This example demonstrates how to capture a video of fixed duration that starts before a given trigger occurs, in this example a key press. 

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/TriggerPastFrames/TriggerPastFrames.bonsai)
:::

## Details
1. Captures the frames from a camera.
2. Delays the camera frames by 1 second, the time we will move back once the trigger occurs.
3. Triggers a *Window* containing 2 seconds of video everytime 'A' is pressed. Because of the delay node in 2, the first frame of this video will start 1 second before the trigger and will end 1 second after.  
4. Retrieves the individual frames of the video. Double-click on this node to visualize the output of the process.  \*


**Note:** A good way of testing this example is turning the camera to your hands as you press 'A'.  


\* If you wanted to save the triggered videos, you can simply add a *VideoWriter* node inside the *SelectMany* node and set the Suffix property to a value different from 'None'.


