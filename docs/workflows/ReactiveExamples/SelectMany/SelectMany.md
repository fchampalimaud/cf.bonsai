# SelectMany

## Summary
This example demonstrates how segment a stream of data into windows of 10 elements, and for each window, create a file with the elements in it using [*SelectMany*](https://bonsai-rx.org/docs/api/Bonsai.Reactive.SelectMany.html)

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/SelectMany/SelectMany.bonsai)
:::

## Details
1. Generates a counter that starts at 0 and gets incremented every 100ms.
2. Creates windows of 10 consecutive elements.
3. Allows a maximum of 5 windows to be created (in case the program does not terminate before that).
4. Creates a file, for each window received, with the elements of each window. 


## Visualization
Save the workflow before running it; the files generated will be saved in the same directory as the workflow. Visualize the *Timer*, *WindowCount* and *SelectMany* nodes using the ObjectTextVisualizer enlarged, such that all the elements generated by each node can be observed. Also, make the visualizers are all open at the start of the program so that no element is left out.


**Note:** The *SelectMany* node in (4) will output the same elements as those generated by the *Timer* node in (1). However, it has done so only after those elements have been packed into windows of 10 elements in (2), and unpacked back inside the *SelectMany* node to be stored in different files. For every window received,  *SelectMany* creates a separate, asynchronous, and independent process inside which it implicitely unpacks the content of the window in the *Source* node and, in this example, it explicitely saves it into a file (see workflow inside *SelectMany* node). 
