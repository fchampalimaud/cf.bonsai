# Elaborate file list processing

## Summary
This example demonstrates how to process a list of files in a given directory (and including subdirectories), and generate output files accordingly.


## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/IO/ElaborateFileListProcessing/ElaborateFileListProcessing.bonsai)
:::


## Details
1. Obtains a list of files from an input directory and initializes the necessary subjects to run the workflow. The input directory, the file search pattern, and the output directory can be set as properties of the group node.
2. Processes each file sequentially.
    1. Selects the current file to be processed from the list of files.
    2. Prepares the output path and file stem that is used to create generate the subsequent output files.
    3. Processes the current file. Here, two output files are created for each input; one with the sum and the other with the multiplication of all the elements in the input file.
    4. Prepares the processing of the next file by updating the file index that will be used in the next iteration.
    5. Creates a delay in the processing of each file to allow the user to visualize the different processing stages (see 3 and 4). This node is used for visualization purposes only and it can safely be removed.
    6. Terminates the current iteration
3. Subscribes the *Current File* subject to visualize the current file being processed.
4. Subscribes the *Status* subject for visualization. The *Status* gets updated at every stage of the processing cycle.


*Before running the code you need to download this [folder](https://drive.google.com/drive/folders/1mqcMzhN2vP5cOGFi4CCXcgHYZ6bmlk9m?usp=sharing), and modify the *Input path* property in the *Init File Processing* node in 1. 



