# Start Camera Sub-Panel

## Summary
This example demonstrates how to combine GUI elements with sub-panels to control the start and the stop of a camera using buttons.

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/GUI/StartCameraSubPanel/StartCameraSubPanel.bonsai)
:::

## Details
1. Creates a workflow to take frames from a camera when the start button is pressed.
    1. Takes images from the camera until the *StopButton* behavior subject* emits a value, which results in terminating the program. This happens when the stop button is pressed in the GUI (see 2.3).
    2. Creates a *BehaviorSubject* with the frames read from the camera. This will be used to visualize the frames in the GUI panel (see 2.4).
    3. Subscribes the preceeding workflow only when an even is received from the *StartButton* behavior subject (see 2.2).

2. Creates two-panel GUI displaced in one row and two columns (1x2) to encorporate all the GUI elements. Double-lick on this node to visualize the GUI panel.
    1. Adds a sub-panel to the GUI with the two buttons.
    2. Adds a Start button to the sub-panel.
    3. Adds a Stop button to the sub-panel.
    4. Adds the image frames to the second panel of the GUI.


## Requirements
You need to install the Bonsai.Gui package available in the nuget.org package source.