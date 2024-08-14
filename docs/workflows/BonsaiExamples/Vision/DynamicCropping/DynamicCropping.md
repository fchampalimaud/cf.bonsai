# Dynamic Cropping

## Summary
This example demonstrates how to set dynamically the values of a compound property of a node, in this case the *RegionOfInterest* of the *Crop* node.

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/Vision/DynamicCropping/DynamicCropping.bonsai)
:::

## Details

1. Creates a black image with three white circles whenever 'S' is pressed.
    1. Creates a black canvas.
    2. Adds three white circles.
    3. Creates an image with the filled image.
    4. Creates a *BehaviorSubject*, *MyImage*, with the three-circle image.
2.  Crops every image created according to a given region of interest. The coordinates of the cropping region can be set dynamically by changing the *Int* nodes from 2.1 to 2.4. 
    1. Defines the X coordinate of the cropping region.
    2. Defines the Y coordinate of the cropping region.
    3. Defines the width of the cropping region.
    4. Defines the height of the cropping region.
    5. Defines the most up-to-date set of coordinate values of the cropping region.
    6. Pairs every image with the current cropping region.
    7. Propagates the current image and sets the RegionOfInterest property of the *Crop* node.
    8. Crops the current image according to the coordinates defined.
