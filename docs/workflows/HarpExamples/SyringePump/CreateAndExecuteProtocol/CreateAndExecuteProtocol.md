# Create and Execute Protocol

## Summary
This example demonstrates how to create and execute a reward delivery protocol using the [Harp SyringePump](https://harp-tech.org/api/Harp.SyringePump.html) (see hardware schematics below).

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/SyringePump/CreateAndExecuteProtocol/CreateAndExecuteProtocol.bonsai)
:::

## Details
1. Establishes the commands to be sent to the Harp SyringePump and publishes all the events from the device. The PortName property in the SyringePump node needs to be set to the COM device on the computer. To create the subject node, right-click on the SyringePump node -> Create Source -> Behavior Subject, and name it accordingly.
2. Defines the protocol to be used.
    1. Sets the protocol direction.
    2. Sets the number of steps of the protocol.
    3. Sets the period of each step of the protocol.
    4. Sets the microstep used in the protocol (full step, half step,...). Smaller microsteps usually mean smoother motor movements.
    5. Ensures that command messages are sent only when the device is ready.
3. Executes the protocol defined in steps 2-5 when `A` is pressed.
    1. Enables the motor so that the protocol can be executed.
    2. This is where the protocol is actually executed.
    3. Delays the data stream so that the motor isn't disabled before the protocol finishes. Beware that for the defined protocol the 1-second delay is enough, but it might not be enough for other protocols. This delay must be adapted according to the protocol used.
    4. Disables the motor so that the controller doesn't heat up when it's not being used.

## Requirements
This example requires:
1. An up-to-date version of the [SyringePump firmware](https://github.com/harp-tech/device.syringepump/releases). This example used the *fw0.6-harp1.6*. To upload the new firmware double-click on the *SyringePump Device* node in Bonsai and follow the instructions.
2. The installation of the Bonsai package *Harp - SyringePump* (from nuget.org).
3. It might also be useful to download the [SyringePump GUI](https://github.com/harp-tech/device.syringepump/releases).

## Schematics
In this example, the [Harp SyringePump](https://harp-tech.org/api/Harp.SyringePump.html) controls a stepper motor.

![Schematics](./CreateAndExecuteProtocolSch.svg){ width=65% }