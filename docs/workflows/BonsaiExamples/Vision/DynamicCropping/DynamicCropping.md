# Dynamic Cropping

## Summary
This example demonstrates how to set dynamically the values of a compound property of a node, in this case the *RegionOfInterest* of the *Crop* node.

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/Vision/DynamicCropping/DynamicCropping.bonsai)
:::

## Details
1. Initializes the behavior subjects necessary to run the example. It receives the *Width* and *Height* of the image as properties and it creates two subjects: *Black Line*, which consists of an image of a single black line, and *Temporary Image* which is initialized with the black line. In addition, it creates a random generator from which the pixel values will be sampled from.
2. Creates an image with random values whenever 'S' is pressed.
    1. Initializes the *Temporary Image* subject to a single black line.
    2. Emits a value for every line that will need to be generated
    3. Generates a new line with random values for each value emited in 2.2.
    4. Appends the current line to the *Temporary Image*.
    5. Checks if all lines have been generated.
    6. When all lines have been generated, it crops the image to remove the black line.
    7. Creates a subject with the finished image.


