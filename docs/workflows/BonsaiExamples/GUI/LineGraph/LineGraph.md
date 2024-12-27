# LineGraph

## Summary
This example demonstrates how to use the LineGraph GUI element to display real-time random data.

## Workflow
:::workflow
![Example](~/workflows//BonsaiExamples/GUI/LineGraph/LineGraph.bonsai)
:::

## Details
1. Creates a continuous uniform distribution [0, 1] from which the random data will be generated.
2. Each second 2 samples are generated from the distribution generated in step 1.
3. The 2 samples are mapped into the X and Y coordinates of a Point2d object. This is the object that must be input in the LineGraph.
4. The LineGraph node responsible for the real-time visualizations.
5. The LineGraph is mapped into a GraphPanel so that the settings from the LineGraph node are applied.
6. Finally, the GraphPanel is mapped into a TableLayoutPanel.

## Requirements
You need to install the Bonsai.Gui package available in the nuget.org package source.
You need to install the following packages:
- Bonsai.Gui (from nuget.org)
- Bonsai - Vision Library (from Bonsai Packages)
- Bonsai - Numerics Library (from Bonsai Packages)
