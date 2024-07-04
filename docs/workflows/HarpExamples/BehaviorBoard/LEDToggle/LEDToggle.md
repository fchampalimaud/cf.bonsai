# Harp.Behavior: LED

## Summary
This example demonstrates how to control the britness of an LED using the current driven ports in the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/LEDToggle/LEDToggle.bonsai)
:::


## Details
1. Establishes the commands to be sent to the Behavior board and publishes all the events from the device. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly.
2. Sets the maximum current to be sent to the LED as a precaution.
3. Sets the actual current to be sent to the LED.
4. Turns the LED ON when 'A' i pressed.
5. Turns the LED OFF when 'S' is pressed.
6. Ensures that command messages are sent only when the device is ready.

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)


## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board has two current sources: Led0 and Led1. In this example, the board controls controls the brightness of an LED connected to Led0.

![Schematics](./LEDToggle.png){ width=65% }







