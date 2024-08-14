# Camera Trigger

## Summary
This example demonstrates how to trigger frames from a camera using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/CameraTrigger/CameraTrigger.bonsai)
:::

## Details
1. Establishes the commands to be sent to the Behavior board and publishes all the events from the device. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the acquisition frequency of the camera.
3. Enables the camera triggers when 'A' is pressed. 
4. Disables the camera triggers when 'S' is pressed.
5. Ensures that command messages are sent only when the device is ready.

## Requirements
This example requires the following Bonsai packages:
- Harp - Behavior (from nuget.org)

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can trigger two cameras using specific PWM signals in ports DO0 and DO1. The DOs output voltage is 5V. In this example, the board triggers frames from a PointGrey camera connected to DO0. 

![Schematics](./CameraTrigger.png){ width=65% }
