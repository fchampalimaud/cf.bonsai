# IO: Process file list

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/IO/ProcessFileList/ProcessFileList.bonsai)
:::

## Summary
This example demostrates how to process each file in a list of files.

## Details
1. Gets a list of files as string array.
2. Generates one event per each element in the string array.
3. Processes each file individually. In this example, for each file, we remove its extension append the string '_new' to it.
4. It prevents Bonsai from stopping once it finishes processing all the files.

## Notes
In this example we are simply modifying the file name in the SelectMany node, but the same principle can be used to opening each of the files, perform some operation on them, and save them with a different name. 


