# Vision: Columnwise Operations

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/Vision/ColumnwiseOperations/ColumnwiseOperations.bonsai)
:::

## Summary
This example demonstrates how to project information of a matrix (in this case an image) into a single row vector using the max function. 

## Details
1. Convert the image to gray scale.
2. Project the max values of each column to a single row vector.

## Follow-up
In addition the Max function one can use the Min, Sum, or Mean values. Row-wise operations can also be used by setting the Axis property in the Reduce node to 1. 