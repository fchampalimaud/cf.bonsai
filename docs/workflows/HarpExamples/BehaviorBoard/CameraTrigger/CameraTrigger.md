# Harp.Behavior: Camera Trigger


## Summary
This example demonstrates how to trigger frames from a camera using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/CameraTrigger/CameraTrigger.bonsai)
:::



## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the acquisition frequency of the camera.
3. Enables the camera triggers when 'A' is pressed. 
4. Disables the camera triggers when 'S' is pressed.

## Requirements
This example requires the folowing Bonsai packages:
- Bonsai - Harp Library
- Harp - Behavior


## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control two cameras in ports DO0 and DO1. In this example, the board triggers frames from a PointGrey camera connected to DO0. 

![Schematics](./CameraTrigger.png){ width=65% }


## Follow-up


