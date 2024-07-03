# Harp.Behavior: PWM

## Summary
This example demonstrates how to control a pwm signal to drive the brightness of an LED using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/PWM/PWM.bonsai)
:::


## Details
1. Establishes the commands to be sent to the Behavior board. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the frequency of the PWM signal to 100Hz.
3. Turns the LED ON when 'A' i pressed.
4. Turns the LED OFF when 'S' is pressed
5. Sets the brightness of the LED by modifying the duty cycle of the PWM according to a triangular wave. 
    1. Generates a triagular wave from that starts at 10, gets incremented by 10 every 500ms, and reaches a maximum value of 90.
    2. Updates the duty cycle property according to the current value of the triangular wave and emits a new event forward.
    3. Sends the new duty cycle signal to the Behavior board.
    4. Creates a new Harp command with the new duty cycle value.
    
## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control four PWM sources in ports: DO0, DO1, DO2 and DO3. The maximum tension used is 5V. In this example, the board controls controls the brightness of an LED connected to DO0. A resistor of 200Ohm is used to drop the current passing through the LED and prevent it from burning.

![Schematics](./PWM.png){ width=65% }

## Follow-up


