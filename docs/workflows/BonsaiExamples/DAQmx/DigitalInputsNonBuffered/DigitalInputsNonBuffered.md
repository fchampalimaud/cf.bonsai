# Digital Inputs (Non-Buffered)

## Summary
This example demonstrates how to read two digital inputs from a National Instruments board in a non-buffered way (ie. sample-by-sample).

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/DAQmx/DigitalInputsNonBuffered/DigitalInputsNonBuffered.bonsai)
:::


## Details
1. Sets the period at which samples will be read from the NI board (50ms in this example).
2. Reads two digial inputs from a NIdaq board. The ports to be read are defined in the *Channels* property. In this example we are using digital ports *\[your-dev\]/port0/line0* and *\[your-dev\]/port0/line1*.
3. Parses the *Mat* data from the *DigitalInput* node to obtain only values pertaining *line0* (above) and *line1* (below).
4. Converts the *Scalar* data in 3 into double. The *Scalar.Val0* is a byte where all bits are zero except the bit that has the same index as the line number; chat bit contains the actual value of the digital port.
5. Converts the double value in 4 to boolean.


Note: This example used a NI USB-6008 board.