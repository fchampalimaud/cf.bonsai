# Reward Delivery

## Summary
This example demonstrates how to give a reward with a feeder. For this example, it is assumed that the feeder is using the wheel that has 40 equally spaced reward positions. The feeder uses the same board as the [Harp SyringePump](https://harp-tech.org/api/Harp.SyringePump.html).

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/Feeder/RewardDelivery/RewardDelivery.bonsai)
:::

## Details
1. Initializes the needed variables/subjects (UpdateStep, StepNumber, NumberOfSteps).
2. Establishes the commands to be sent to the SyringePump board and publishes all the events from the device. The PortName property in the SyringePump node needs to be set to the COM device on the computer. To create the subject node, right-click on the SyringePump node -> Create Source -> Behavior Subject, and name it accordingly.
3. Sets the SyringePump protocol direction to `Forward`.
4. Sets the number of steps of the SyringePump protocol. The number of steps changes according to 9. and 10. to compensate for the fact that the board doesn't accept non-integer number of steps.
5. Sets the step period to 10 ms (default value).
6. Sets the step mode to quarter-step. Feel free to try other step modes, but remember to change the number of steps accordingly if you intend to keep the same amount of "movement" (**CHANGE THIS EXPRESSION**).
7. Ensures that command messages are sent only when the device is ready.
8. Gives a reward when `A` is pressed.
    1. Enables the motor.
    2. Executes the SyringePump protocol.
    3. Disables the motor.
9. Updates the StepNumber Behavior Subject every time a reward is given. If the current StepNumber is equal to 5 it updates to 1, otherwise it adds 1 to the current value.
10. Updates the NumberOfSteps Behavior Subject (which in turn updates the protocol step count) according to the current StepNumber. If StepNumber is less than 4, the NumberOfSteps is set to 104, otherwise it is set to 103.

## Requirements
This example requires the following Bonsai packages:

- Harp - SyringePump (from nuget.org)

## How to calculate the needed number of steps per reward
In the [Details](#details) section, the fact that the number of steps per protocol is either 103 or 104 seems arbitrary, but there's a reason for it. This section aims to address how one can calculate the needed number of steps to deliver consecutive rewards that are equally spaced in the circular mechanism.

For the case presented above, we know that there are 40 possible reward positions. The angle that separates 2 consecutive rewards is given by:

$$\frac{360\degree}{40} = 9\degree$$

So every time a SyringePump protocol is executed, the mechanism should advance $9\degree$. To convert this value to motor steps, one has to divide it by the amount of degrees that a motor step is equivalent to. For the feeder's motor, each motor step is equivalent to $1.8\degree$. However, the motor has an internal gear so that in order for the shaft to make a full rotation it's necessary that the motor fully rotates 5.18 times. With this in mind, it's now possible to calculate the number of full-steps needed for the shaft to move $9\degree$:

$$\frac{9\degree}{\frac{1.8\degree}{5.18}} = \frac{9\degree \times 5.18}{1.8\degree} = 25.9 \text{ steps}$$

Then, since the stepper motor has different micro steps (or step modes), such has half-steps or quarter-steps, there's a need to multiple the previous result with the respective micro step multiplier.
- Full-step: x1
- Half-step: x2
- Quarter-step: x4
- Eighth-step: x8
- Sixteenth-step: x16

Since the example above uses quarter-step, we get:

$$25.9 \times 4 = 103.6 \text{ quarter-steps}$$

Finally, as mentioned before, it is not possible to execute SyringePump protocols with non-integer number of steps. If one decides to just round the result either up or down, it will cause a cumulative displacement error of the disk in the long term. For this example, this cumulative displacement error can be completely corrected by executing 2 protocols with 103 steps every 5 protocols and the remaining 3 out of 5 protocols with 104 steps (because $103.6 \times 5 = 103 \times 2 + 104 \times 3 = 518 \text{ steps}$).
