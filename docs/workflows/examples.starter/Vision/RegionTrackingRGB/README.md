# CF.Bonsai.Vision RGB Region Tracking 

## Summary

This example tracks the biggest object with RGB values bounded within a range. To track your object you have to:
1. Define the lower and upper ranges of the RGB values in the RangeThreshold node, such that your object is as isolated as possible from the background.
2. Define the MinArea and MaxArea in the FindContours node (in pixels). This should further isolate the your object from the background.
3. By using the LargestBinaryRegion node you select the largest region in your images that passed your criteria in 1 and 2. 

