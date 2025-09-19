# LineGraph

## Summary
This example demonstrates how to use the LineGraph GUI element to display real-time random data.

## Workflow
:::workflow
![Example](~/workflows//BonsaiExamples/GUI/LineGraph/LineGraph.bonsai)
:::

## Details
1. Each second both the sine and cosine are calculated and zipped.
2. The sine and cosine are mapped into the X and Y coordinates of a Point2d object. This is the object that must be input in the LineGraph.
3. The LineGraph node responsible for the real-time visualizations.
4. The LineGraph is mapped into a GraphPanel so that the settings from the LineGraph node are applied.
5. Finally, the GraphPanel is mapped into a TableLayoutPanel.

## Requirements
You need to install the Bonsai.Gui package available in the nuget.org package source.
You need to install the following packages:
- Bonsai - GUI (from nuget.org)
- Bonsai - GUI ZedGraph (from nuget.org)
- Bonsai - Vision Library (from Bonsai Packages)
- Bonsai - Numerics Library (from Bonsai Packages)
