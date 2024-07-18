# Servo Motor Control


## Summary
This example demonstrates how to control a servo motor using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/ServoMotorControl/ServoMotorControl.bonsai)
:::



## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the period of the servo motor's pwm in microseconds. Normal servos use a period of 20.000us.
3. Enables the servo motor when 'A' is pressed. 
4. Disables the servo motor when 'S' is pressed.
5. Sets the desired angle of the servo motor. 
    1. Converts the angle into a pwm pulse width, which typically ranges between a minimum value of 1000us and a maximum value of 2000us. 
    2. Converts the pulse width into an integer value.
    3. Sets the pulse width property of the servo motor and emits a new event forward.
    4. Creates a new Harp message with the new pulse width. 

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior


## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control two servo motors in ports DO2 and DO3. The DOs output voltage is 5V. In this example, the board controls controls the position of a servo motor connected to DO2. 

![Schematics](./ServoMotorControl.png){ width=65% }







