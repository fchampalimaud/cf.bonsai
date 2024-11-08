# Create Int Array

## Summary
This example demostrates how to create an array with N elements whenever a key is pressed.

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/DataTypes/CreateIntArray/CreateIntArray.bonsai)
:::

## Details
1. Creates an Int array whenever 'A' is pressed.
2. Creates an array of 10 elements using a Range node (count=10) followed by a ToArray node, inside a SelectMany node (see inside the SelectMany node).
3. Gets the values in of the 3 first indexes of each array generated in 2.
4. Zips the 3 elements of each array index for visualization purposes. Double-click on this node to visualize the first three elements of the array.

