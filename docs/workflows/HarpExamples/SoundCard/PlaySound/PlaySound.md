# Play Sound

## Summary
This example demonstrates how to play a .wav file using the [Harp SoundCard](https://harp-tech.org/api/Harp.SoundCard.html) board (see hardware schematics below). 

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/SoundCard/PlaySound/PlaySound.bonsai)
:::

## Details
The Harp SoundCard board allows the user to upload wav files using its graphical user interface (see details [here](#uploading-sounds-to-the-harp-soundcard)). Each file is linked to an index (2-31), which can be played by the sound card. 
1. Establishes the commands to be sent to the SoundCard board. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subject node, right-click on the SoundCard node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Plays the sound stored at index 4, when 'A' is pressed. \*
3. Plays the sound stored at index 5, when 'S' is pressed. \*\*
4. Ensures that command messages are sent only when the device is ready.
    
\* The example file loaded in index 4 can be found here \
\*\* The example file loaded in index 5 can be found here

## Requirements
This example requires the following Bonsai packages:
- Harp - SoundCard (from nuget.org)

Additionally, install the [Harp SoundCard](https://github.com/harp-tech/device.soundcard) GUI in order to upload sounds to the SoundCard.

## Schematics
_TODO_

## Uploading sounds to the Harp SoundCard
1. Install the [Harp SoundCard](https://github.com/harp-tech/device.soundcard) GUI.
2. Open the GUI. Then click on `Launch`.
3. It is possible to generate pure tones and white noises or to load sounds from .wav or binary files. Either way, after tweaking with the configurations according to one's needs, click on the correct `Generate` button (for a sound loaded from a .wav - or binary - file, the button is names `Load and Generate`). The sound will be plotted in the figure at the bottom of the GUI.
4. In the `Interface with the Sound Card` frame of the GUI, select the index (between 2 and 31) where the sound will be uploaded to in the device's memory. Then click on `Create files and send to device`.
5. _Optional:_ To play the sound, select the device's COM port and sound index in the bottom right corner of the GUI (above the plot) and hit the `Play` button.
6. _Mandatory:_ Party as hell to your recently uploaded sound! :D
