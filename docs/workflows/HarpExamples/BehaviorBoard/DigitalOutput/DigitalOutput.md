# Digital Output

## Summary
This example demonstrates how to control the ON/OFF state of an LED using the digital output from the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/DigitalOutput/DigitalOutput.bonsai)
:::

## Details
1. Establishes the commands to be sent to the Behavior board and publishes all the events from the device. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Turns the LED ON when 'A' is pressed.
3. Turns the LED OFF when 'S' is pressed
4. Ensures that command messages are sent only when the device is ready.

## Requirements
This example requires the following Bonsai packages:
- Harp - Behavior (from nuget.org)

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control four digital output ports: DO0, DO1, DO2, and DO3. The DOs output voltage is 5V. In this example, the board controls the ON/OFF state of an LED connected to DO0. A resistor of 200Ohm is used to drop the current passing through the LED and prevent it from burning.

![Schematics](./DigitalOutput.png){ width=65% }

## Follow-up
