# Streams to Mat

## Summary
This example shows how the make two streams of data converge into a *OpenCV.Net.Mat* data type.


## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/DataTypes/StreamsToMat/StreamsToMat.bonsai)
:::


## Details
1. Creates a random distribution.
2. Generates a random value every 0.5s, multiplies it by two, and combines the two into a single *Mat* value.
    1. Combines every value from the *Timer* with the distribution created in 1.
    2. Selects the distribution.
    3. Samples one value from the distribution.
    4. Multiplies the value by 2.
    5. Combines the values from 3 and 4.
    6. Creates a buffer every time two elements are received as a *Mat*.
    7. Transposes the buffer for visualization purposes. Double-click on this node to visualize the resulting *Mat* content.  




