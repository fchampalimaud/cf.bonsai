# Harp.Behavior: Camera Trigger

## Summary
This example demonstrates how to trigger a camera by generating a PWM signal in the Harp Behavior board. LINK TO BEHAVIOR BOARD


## Workflow

:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/CameraTrigger/CameraTrigger.bonsai)
:::


## Details
1. Establishes the commands to be sent to the Behavior board. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the frequency of the PWM signal. In the example this is set only once, at the beginning.
3. Starts the PWM signal when 'A' is pressed. 
4. Stops the PWM signal when 'S' is pressed.

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)



