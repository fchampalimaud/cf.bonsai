# Harp.Behavior: Digital Outputs

## Workflow

:::workflow
![Example](~/workflows/examples.starter/Harp/Harp.Behavior/DigitalOutputs/DigitalOutputs.bonsai)
:::

## Summary

ADD REGISTER CODE SOMEWHERE https://harp-tech.org/api/Harp.Behavior.html

This example demonstrates how to control the light produced by an LED connected to the Harp Behavior board. The board can control an LED in four ways: setting directly the current that flows through the LED thus regulating its intensity (direct current control), using a pwm digital signal to regulate the intensity of the LED (PWM control), using a digital signal to set the LED ON/OFF, and triggering a digital pulse with a given width that controls the ON/OFF state of the LED. 

Important note: It is advisable to use a resistor in series with the LED when using the digital signals, to prevent it from burning. The value of the resistor depends on the LED and on the brightness desired, but one can start with a ~200Ohm resistor (see schematics below).
LINK TO BEHAVIOR BOARD

## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the intensity of the LED by current : ON when 'A' pressed and OFF when 'S' pressed.
3. Triggers a pulse in digital port D01 (width=1000s) whenever 'A' is pressed

## Schematics
ADD Schematics
The bhavior board can control 4 digital outputs  portsXXX....

## Follow-up





