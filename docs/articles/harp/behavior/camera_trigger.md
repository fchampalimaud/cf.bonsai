# Harp.Behavior: Camera Trigger

## Workflow

:::workflow
![Example](~/workflows/examples.starter/Harp/Harp.Behavior/CameraTrigger/CameraTrigger.bonsai)
:::

## Summary
This example demonstrates how to trigger a camera by generating a PWM signal in the Harp Behavior board. LINK TO BEHAVIOR BOARD

## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the frequency of the PWM signal. In the example this is set only once, at the beginning.
3. Starts the PWM signal when 'A' is pressed. 
4. Stops the PWM signal when 'S' is pressed.

## Follow-up

