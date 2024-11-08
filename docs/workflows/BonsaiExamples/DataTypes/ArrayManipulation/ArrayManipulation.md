# Array Manipulation

## Summary
This example demonstrates how to create an array, add elements to it and remove elements from it. 

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/DataTypes/ArrayManipulation/ArrayManipulation.bonsai)
:::

## Details
1. Create an int array with one element.
    1. Receives a single int value and terminates the sequence. Closing the sequence is essential to create the array (see 1.2). 
    2. Creates an array with the single int value received.
    3. Initializes the subject MyArray with the int array created.
2. Adds a new int value to the array whenever 'A' is pressed.
    1. Gets the current number of 'A' key presses.
    2. Creates a new int array with the elements in MyArray added by the current number of key presses.
    3. Updates MyArray with the new array created.
3. Removes the last element from MyArray whenever 'S' is pressed.
    1. Creates a new array without the last element.
    2. Updates MyArray with the new int array created.
4. Outputs the current values of the array at 200ms intervals.
    1. Enables the visualization of the current content of MyArray. Double-click on this node to visualize the current content of the *Int* array.
    2. Extracts the length of the current array. Double-click on this node to visualize it.


## Notes
The key elements of this workflow are the *Concat* and *ToArray* nodes from the Reactive package. *Concat* produces a flat sequence of values with the individual elements of an array, while *ToArray* composes an array out of a flat sequence of values (insofar as that sequence terminates). Mastering these two nodes is key to understanding this example.
