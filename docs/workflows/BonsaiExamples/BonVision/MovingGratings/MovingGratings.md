# Moving Gratings

## Summary
This example demonstrates how to create gratings of different orientations on the press of a key.

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/BonVision/MovingGratings/MovingGratings.bonsai)
:::

## Details
1. Creates and initializes a simple shaders window with the standard resources necessary to draw the gratings. 
2. Creates an orthographic view with the normalized window coordinates, and sets up a behavior subject 'DrawScene' to be used whenever an update is to occur.
3. Draws a circle with a moving grating at the center of the current scene (check the grating settings in the node properties). 
4. Sets the orientation of the grating to horizontal when 'A' is pressed.
5. Sets the orientation of the grating to vertical when 'S' is pressed.




