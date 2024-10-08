# Region Tracking RGB

## Summary
This example demonstrates how to setup a simple tracker based on thresholding the RGB channels.

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/RegionTrackingRGB/RegionTrackingRGB.bonsai)
:::

## Details
1. Threshold each of the input channels between a lower and an upper bound. Modify those bounds such that your particular object can be separated from the background. 
2. In the thresholded image, find regions of contiguous pixels. You can set a minimum and/or a maximum number of acceptable contiguous pixels.
3. For each region identified, calculate a number of properties, such as position of the centroid, orientation, etc.
4. From the list of selected regions, select the largest region and show the x and y position of the centroid.

## Follow-up
See also the [RegionTrackingHSV](../RegionTrackingHSV/RegionTrackingHSV.md) example.
