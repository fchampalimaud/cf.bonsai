# Audio: Play Tone

## Summary
This example demonstrates how to play a tone with fixed frequency and duration whenever a key is pressed.


## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Audio/PlayTone/PlayTone.bonsai)
:::


## Details
1. Plays a tone whenever 'A' is pressed.
    1. Generates a sinusoidal wave form with 44100 samples with amplitude of 10000 and frequency of 1000Hz. Given that the sampling rate is set to 44100Hz, the wave generated will allow the tone to last for 1s.
    2. Plays the tone.

## Follow up
The  example shows how to modify the frequency and durations to obtain different tones on-the-fly.


