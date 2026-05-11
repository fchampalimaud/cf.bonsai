# Reproducible Research Practices
Bonsai is a great tool for prototyping ideas and easily interact with a great variety of hardware (eg.: cameras, Arduinos, Harp devices,...). However, one will eventually want to go from the prototyping phase to start building a project/setup that will be used in the research. 

At this stage, prototyping will continue to play an important role given the nature of research, but another aspect may have to be considered as well: reproducibility.

Reproducibility is a core pillar of the scientific method. However, in this section we are more interested in the technical reproducibility, which can be achieved via standardization.

## Why is standardization important? When? And how much?
> [!NOTE]
> This subsection is a discussion about the importance of standardization and on what degree of standardization may be adopted in different situations. 
> 
> If you are only interested in the tools and strategies part, click [here](#tools-and-strategies).

Before diving into specific areas where standardization can be applied to your project, let's first discuss standardization from a pragmatic perspective (hopefully).

One of the main reasons why we standardize procedures is to decrease some sort of mental (and/or physical) effort. For example, if we adopt the Bonsai and Harp ecosystems for our experiments and start getting familiar with them, eventually the amount of effort needed to develop new features or projects decreases, which frees some time and mental space to focus on different things such as the science the behind the experiment. Another example would be to standardize the way we organize our projects or save data and results, which helps revisiting those at a later stage.

When standards are adopted by multiple people, it becomes easier to share ideas, projects and efforts, since communication is made with the same framework in mind. For example, if a lab or an institute uses the same tools, it facilitates technical knowledge transfer and decreases development time. It may even speed up troubleshooting because it's more probable that more people have struggled with the same issues in the past.

The degree to which standards should be adopted depends on the project's needs. For example:
- If scale is important (i.e. if we want to build multiple setups) or if we want that a different group can easily replicate our setup(s), it's recommended that the necessary software is accessible and is easy to install and configure (writing documentation helps). 
- If my task has a lot of configurable parameters, it's a good idea to have a configuration file that is loaded at the beginning of the session; whereas if my task only has 2 or 3 parameters, it may not be worth the effort and it's easier to change those directly in the Bonsai workflow.

So, generally speaking, two good pragmatic rules of thumb on standardization are:
- The more complex a project is, the bigger the amount of standardization required.
- Standardizing a procedure is only worth if the time/effort it takes to standardize it is less than the time/effort it takes to execute the current procedure, i.e. if there's a medium-to-long term gain in efficiency.

## Tools and strategies
After briefly talking about the importance of standardizing procedures, we will now present concrete tools and strategies you can adopt in your projects.

> [!NOTE]
> The tools and methods presented below are only recommendations. Ultimately, the user has to decide which ones are worth adopting.

> [!WARNING]
> There are much more tools and strategies than the ones presented below. Beside general project organization, the tools presented below were picked due to at least one of the following reasons:
> - Interact seamlessly with the Bonsai ecosystem
> - Were developed in-house
> - Leverage open-source hardware and software

<!-- ### Version Control
- git
- github

### Project directory tree
- Portable bonsai executable (dedicated environment)
- Output directory structure

### Python tips
- Sgen
- Startup and shutdown scripts
- uv

### Harp
- harp-python


## Examples
- SoundLateralizationTask
- WeightLiftingTask
- Pull2Reach
- RedLightGreenLight
- cf.labs -->
