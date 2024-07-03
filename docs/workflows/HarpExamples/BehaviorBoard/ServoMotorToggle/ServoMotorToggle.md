# Harp.Behavior: Servo Motor Toggle


## Summary
This example demonstrates how to toggle a servo motor between two positions using [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/ServoMotorToggle/ServoMotorToggle.bonsai)
:::



## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the period of the servo motor's pwm in microseconds. Normal servos use a period of 20.000us.
3. Enables the servo motor when 'A' is pressed. 
4. Disables the servo motor when 'S' is pressed.
5. Toggles whenever 'Space' is pressed. 
    1. Sets the minimum or maximum motor angle according to the (even or odd) number of times the 'Space' key was pressed. This angle is expressed in a pulse width that typically ranges between 1000us and 2000us.
    2. Sets the pulse width property of the servo motor and emits a new event forward.
    3. Creates a new Harp message with the new pulse width. 

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior


## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control two servo motors in ports DO2 and DO3. The maximum tension used is 5V. In this example, the board controls controls the position of a servo motor connected to DO2. 

![Schematics](./ServoMotorToggle.png){ width=65% }


## Follow-up





