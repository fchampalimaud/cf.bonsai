# Single Pixel Value

## Summary
This example demonstrates how to obtain the intensity value of a single pixel in a grayscale image.

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/SinglePixelValue/SinglePixelValue.bonsai)
:::

## Details
1. Creates a grayscale canvas with a white circle in the middle when 'A' is pressed.
2. Creates a grayscale image with a light gray circle in the middle when 'S' is pressed.
3. Creates a grayscale image with a dark gray circle in the middle when 'D' is pressed.
4. Transforms the canvas into an image.
5. Retrieves the pixel information at the center (50,50).
6. Retrieves the intensity value of the grayscale pixel, using the first channel (Val0).\* To obtain this node, write-click over the ExpressionTransform node select Ouptut -> Val0.

\* For coloured images, the output values Val0, Val1, Val2, will contain the intensity values of the blue, green and red channels, respectively (the order might change for diferent images).

