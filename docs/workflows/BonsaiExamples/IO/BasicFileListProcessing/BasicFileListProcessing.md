# Basic file list processing

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/IO/BasicFileListProcessing/BasicFileListProcessing.bonsai)
:::

## Summary
This example demostrates how to read data from a list of files in a given directory, process each file individually to create a new set of corresponding output files. The output files will be placed in the same directory as the input files.

## Details
1. Gets a list of filenames, with *\*.txt* extension, from a given directory as string array.\*
2. Generates one event per each element in the string array.
3. Processes each file individually. In this example, we read the number stored in each file, multiply it by two, and create a new file with the result with the string '_new' added to it.

\*Before running the code you need to download *file1.txt* and *file2.txt* from [here](https://github.com/fchampalimaud/cf.bonsai/blob/main/docs/workflows/BonsaiExamples/IO/BasicFileListProcessing) to a directory, and modify the *Path* propery in the *GetFiles* node accordingly. 


## Follow up
A more elaborated example for processing a list of files can be found [here](/workflows/BonsaiExamples/IO/ElaborateFileListProcessing/ElaborateFileListProcessing.html)
