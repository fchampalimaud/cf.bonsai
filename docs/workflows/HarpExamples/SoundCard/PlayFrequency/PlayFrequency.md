# PWM Toggle

## Summary
This example demonstrates how to control a PWM signal to drive the brightness of a LED using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/PWMToggle/PWMToggle.bonsai)
:::

## Details
1. Establishes the commands to be sent to the Behavior board. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the duty cycle of the PWM signal to 50%.
3. Initiates the PWM signal.
4. Sets the PWM frequency to 1Hz when 'A' is pressed.
5. Sets the PWM frequency to 5Hz when 'A' is pressed.
6. Ensures that command messages are sent only when the device is ready.
    
## Requirements
Install Harp SoundCard (https://harp-tech.org/api/Harp.SoundCard.html)

This example requires the following Bonsai packages:
- Harp - SoundCard (from nuget.org)

