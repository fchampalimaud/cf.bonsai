# Other: Array Manipulation

## Summary
This example demonstrates how to create an array, add elements to it and remove elements from it. 


## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Other/ArrayManipulation/ArrayManipulation.bonsai)
:::


## Details
1. Create an int array with one element
    1. Receives a single int value and terminates the sequence. Closing the sequence is essential to create the array (see 1.2). 
    2. Creates an array with the single int value received.
    3. Initializes the subject MyArray with the int array created.
2. Adds a new int value to the array whenever 'A' is pressed.
    1. Gets the current number of 'A' key presses.
    2. Creates a new int array with the elements in MyArray added by the current number of key presses.
    3. Updates My array with the new array created.
3. Removes the last element from MyArray whenever 'S' is pressed.
    1. Creates a new array without the last element.
    2. Updates MyArray with the new int array createdy.
4. Outputs the current values of the array at 200ms intervals
    1. Enables the visualization of the current content of MyArray



## Notes
The key elements of this workflow are the Concat and ToArray nodes from the Reactive package. Concat produces a flat sequence of values with the individual elements of an array, while ToArray composes an array out of a flat sequence of values (insofar as that sequence terminates). Mastering these two nodes is key to understanding this example.

