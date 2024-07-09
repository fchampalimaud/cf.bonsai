# Shaders: Moving Circle

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/BonVision/MovingCircle/MovingCircle.bonsai)
:::

## Summary
This example demonstrates how to draw a circle in Shaders and update its position according to mouse movements.

## Details
1. Creates and initializes a simple shaders window with the standard resources necessary to draw the circle. 
2. Creates an orthographic view with the normalized window coordinates, and sets up a behavior subject 'DrawScene' to be used whenever an update is to occur.
3. Draws a circle in the current scene. 
4. Modifies the position of the circle according to the position of mouse. The position of the mouse in  the screen is normalized to the shader window coordinates to facilitate the interaction.

Move the mouse over the Shaders window to observe the result.

## Follow-up


