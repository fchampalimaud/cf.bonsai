# Harp.Behavior: Camera Trigger


## Summary
This example demonstrates how to trigger frames from a camera using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/CameraTrigger/CameraTrigger.bonsai)
:::



## Details
1. Establishes the commands to be sent to the Behavior board. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the acquisition frequency of the camera.
3. Enables the camera triggers when 'A' is pressed. 
4. Disables the camera triggers when 'S' is pressed.

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)


## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can trigger two cameras using specific PWM signals in ports DO0 and DO1. The maximum tension used is 5V. In this example, the board triggers frames from a PointGrey camera connected to DO0. 

![Schematics](./CameraTrigger.png){ width=65% }


## Follow-up

