# Annotate Array of Points

## Summary
This example demonstrates how to annotate an array of points using circles. 

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/AnnotateArrayOfPoints/AnnotateArrayOfPoints.bonsai)
:::

## Details
1. Creates distribution to sample values for the position of each circle in the array.
2. Creates an array of points whenever 'A' is pressed and initializes an empty canvas.
3. Draws a circle centered in each point of the array.
    1. Creates an event for each point in the array.
    2. Associates each event with the current canvas (starting with the empty canvas for the first point in the array).
    3. Uses the current canvas (Item2) for drawing a circle centered around the current point (Item1).
    4. Updates the current canvas, which will allow for a new point to pass through the Zip node (3.2).
    5. Skips every point until it reaches the last point in the array, the point at which the Current Canvas with all the points in it will be propagated.
    6. Draws the canvas with all the points in it.


## Follow-up
The same framework could be used to write text in each of the points in the array using the node AddText. For more other annotation possibilities type 'Vision.Drawing' in the Bonsai toolbox.
