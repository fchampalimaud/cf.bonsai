# Digital Output Pulse

## Summary
This example demonstrates how to trigger a digital pulse, with a fixed duration, on an LED using the digital output from the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/DigitalOutputPulse/DigitalOutputPulse.bonsai)
:::


## Details
1. Establishes the commands to be sent to the Behavior board and publishes all the events from the device. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly.
2. Enables triggering pulses in port DO0.
3. Sets the pulse duration to 1000ms.
4. Triggers the pulse whenever 'A' is pressed.
5. Ensures that command messages are sent only when the device is ready.

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can trigger pulses in seven digital output ports: DO0, DO1, DO2, DO3, DOPort0, DOPort1, DOPort2, and the LED current ports: Led0, Led1. The output voltage of these ports is 5V. In this example, the delivers a digital pulse to an LED connected to DO0. A resistor of 200Ohm is used to drop the current passing through the LED and prevent it from burning.

![Schematics](./DigitalOutputPulse.png){ width=65% }








