# Sample Nomrmal Distribution

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/Numeric.Distributions/SampleNormalDistribution/SampleNormalDistribution.bonsai)
:::


## Summary
This example demostrates how to randomly sample from a continuous normal distribution.

## Details
1. Creates BehaviorSubject (MyDistribution) with a normal distribution with mean of 0 and standard deviation of 1.
2. Samples randomly from MyDistribution when 'A' is pressed.

Visualize the output of Sample node using the TimeSeriesVisualized and while maintaining 'A' pressed.

If you want to repeat the same randomly sampled values everytime Bonsai is started set the Seed property to a value in the CreateRandom node.

**Important Note:** If you want to sample more than once from a given distribution do not connect the Sample directly to the output of the CreateNormal node. This will recreate the distribution everytime you take sample, which will result in undesired results.


