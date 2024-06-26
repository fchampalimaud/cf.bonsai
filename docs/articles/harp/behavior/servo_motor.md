# Harp.Behavior: Servo Motor

## Workflow

:::workflow
![Example](~/workflows/examples.starter/Harp/Harp.Behavior/ServoMotor/ServoMotor.bonsai)
:::

## Summary
This example demonstrates how to control the position of a servo motor using the Harp Behavior board. When enabled (press A), the servo will change position everytime a new value is emitted from the Int node (3.).
LINK TO BEHAVIOR BOARD

## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets the period of the servo motor's pwm in microseconds. Normal servos use a period of 20.000us.
3. Sets the desired angle of the servo motor. 
__3.1. Converts the angle into a pwm pulsewidth, which typically ranges between a minimum value of 1000us and a maximum value of 2000us. 
__3.2. Converts the pulse witdt into an integer value
__3.3. Sets the pulsewidth property of the servo motor and emits a new event forward
__3.4. Creates a new Harp message with the new pulsewidth 
4. Enables the servo motor when 'A' is pressed. 
5. Disables the servo motor when 'S' is pressed.

## Schematics
ADD Schematics
The behavior board can control two servo motors... portsXXX

## Follow-up





