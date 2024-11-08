# Sample Discrete Uniform Distribution

## Summary
This example demonstrates how to randomly sample from a discrete uniform distribution.

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/Numeric.Distributions/SampleDiscreteUniformDistribution/SampleDiscreteUniformDistribution.bonsai)
:::

## Details
1. Creates BehaviorSubject (MyDistribution) with a discrete uniform distribution with values ranging from 0 to 10.
2. Samples randomly from MyDistribution when 'A' is pressed. Double-click on the *Sample* node, and press 'A' several times, to visualize the random numbers generated.

If you want to repeat the same randomly sampled values everytime Bonsai is started, set the Seed property to any value in the *CreateRandom* node.

**Important Note:** If you want to sample more than once from a given distribution do not connect the *Sample* node directly to the output of the *CreateDiscreteUniform* node. This will recreate the distribution everytime you take sample, which will produce undesired results.
