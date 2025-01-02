
## Combinators tutorial

### 0. Reactive Combinators

<table>
<tr>
<td> <img src="~/workflows/Tutorials/Combinators/reactive-merge.svg" alt="Merge"/> </td>
<td> <img src="~/workflows/Tutorials/Combinators/reactive-zip.svg" alt="Zip"/> </td>
</tr>
<tr>
<td> <img src="~/workflows/Tutorials/Combinators/reactive-concat.svg" alt="Concat"/> </td>
<td> <img src="~/workflows/Tutorials/Combinators/reactive-combinelatest.svg" alt="CombineLatest"/> </td>
</tr>
<tr>
<td> <img src="~/workflows/Tutorials/Combinators/reactive-withlatestfrom.svg" alt="WithLatestFrom"/> </td>
</tr>

</table>



<details>
<summary>Solution</summary>

:::workflow
![Example](~/workflows/Tutorials/Combinators/CropVideos.bonsai)
:::

</details>



11. Pair a Timer (Period=1s) and an Int (Value=2), to three different combinators concurrently (i.e. in the same workflow): Zip, CombineLatest, WithLatestFrom. Use the Timer as the first input and the Int as the second input to all combinators, and analyze the output of the combinators. What do you see? Take your time to think about it. Does the behavior match the description of the combinators?
12. Switch the order of the nodes in (11) such that the Int is now the first input and the Timer the second. Before you run your code, write down the output you expect for each of the combinators. Do your predictions match the real outcomes?
Tip: You can drag the second element into the first element while pressing Alt.
13. Visualize the coordinates of your mouse position using the ObjectTextVisualizer, and save them into a CSV file. Open the file in Notepad? Do you understand everything you see?
Tip: MouseMove, CSVWriter
14. Timestamp the mouse coordinates and add them to another CSV file. Can you open the text file and see the values inside? 
Tip: Timestamp
15. Substitute the Timestamp node by the ElementIndex node in the previous example and add them to another CSV file. Can you interpret the output of the CSV file?  
16. Visualize the audio input from your microphone in the MatVisualizer. Try whistling 








