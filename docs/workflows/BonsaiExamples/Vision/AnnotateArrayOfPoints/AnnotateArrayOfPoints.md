# Annotate Array of Points

## Summary
This example demonstrates how to annotate an array of points using circles. 

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/AnnotateArrayOfPoints/AnnotateArrayOfPoints.bonsai)
:::

## Details
1. Creates distribution to sample values for the position of each circle in the array.
2. Creates an array of points and creates an array of points  whenever 'A' is pressed.
3. Draws a circle centered in each point of the array.
    1. Creates an event for each point in the array.
    2. Associates each event with the current canvas (starting with the empty canvas for the first point in the array).
    3. Sets the current canvas (Item2) for drawing a circle centered around the current point (Item1).
    4. Draws the circle into the current canvas.
    5. Updates the current canvas, which will allow for a new point to pass through the Zip node (3.2)
    6. Terminates the drawing in the current canvas after 10 points have been drawn
    6. Repeats the process, and waits for another set of points to arrive.
4. Draws the current canvas. Double-click on this node to visualize the output of the entire process.

## Follow-up
The same framework could be used to write text in each of the points in the array using the node AddText. For more other annotation possibilities type 'Vision.Drawing' in the Bonsai toolbox.
