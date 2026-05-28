# Version Control
It's difficult to navigate the current research environment without encountering code in one form or another. Whether it's written in MATLAB, Python, Bonsai or any other programming language. Whether it's code that makes a setup work or that analyzes data acquired in one of these setups. Whether it's written by a person or by a LLM.

If you have to write any sort of code for your research, there are a two points you have to consider:
- how to keep track of modifications made to the code.
- where to host the code so that it can be accessed from different computers or shared with other lab members or the larger scientific community.

The first point can be solved with [Git](https://git-scm.com/), whereas the second can be solved in platforms such as [GitHub](https://github.com/) and [GitLab](https://gitlab.com/).

## Git
Git is a universally adopted version control tool. This tool allows a programmer to modify a project, keep track the history of modifications, create a parallel branch of the project to experiment ideas or develop new features without compromising the main branch that is known to be working. All of these operations are made locally and without the need of creating copies of the project (no more `ProjectV2` and `ProjectFinal` and `ProjectFinalForRealThisTime` directories).

> [!NOTE]
> To learn how to leverage Git to host your code remotely, read the [GitHub/GitLab](#githubgitlab) section.

Let's create our first Git (local) repository. In this tutorial, we'll simply create a project that consists of a single text file called `README.md`.
1. Create a directory somewhere in your computer and a `README.md` file inside.
2. Open a terminal and navigate to the project directory.
    > [!TIP]
    > In the terminal, you can use the command `ls` to see what's inside the directory you're currently in. To go to a specific directory run `cd [directory_name]`.
    >
    > _Special case:_ to navigate to the previous directory run `cd ..`.
3. Start the repository run:
    ```
    git init
    ```
4. Let's now create our first item in the repository's history, which is called a _commit_. Firstly, let's add the files/changes we want to track. In our case, we only want to track the `README.md` file.
    ```
    git add README.md
    ```
    > [!TIP]
    > Although it's not recommended, you can add every file in the project by running `git add .`
5. After staging the `README.md` file, let's create the first commit of the repo. Every commit usually has a message attached that describes what modifications were made. This way, it's easier to have an idea of how the project evolved with time.
    ```
    git commit -m "initial commit"
    ```

With what we learned so far, we can already keep track of the modifications made to the project across time. If eventually we add a new file to the project or modify the `README.md` file, we simply have to repeat steps 4 and 5.

### Branching and merging
Now let's assume that the project is in a state that's usable either by us or by a colleague, but in which we want to work on a new feature or refactor some code. That's were branching and merging come in.

> [!IMPORTANT]
> In this situation, we could also just commit the new changes as before and since Git is a version control tool we have access to the project's history so we could simply go back to the commit we know for sure that is working. Although possible, it's not common practice and, for that reason, it's out of the scope of this tutorial.

A possible strategic could be to have two branches: one with the latest stable version of our code and the other in which we develop new features. By default, when we create a repository, there's only the `main` branch (sometimes called `master` instead). So, let's create a new branch called `develop`.
```
git branch develop
```

The `develop` branch was created but we are still in the `main` branch. We can confirm this fact by running:
```
git status
```

In order to change to the `develop` branch, we need to run the following command:
```
git checkout develop
```

If we run `git status` again, we verify that we are now in the `develop` branch. However, nothing seemed to have changed in our project. That's because it hasn't. Both branches contain exactly the same content, which in our case is only our `README.md`. Let's change that!

Edit the `README.md` file and repeat steps 4 and 5 from above. Don't forget to use attach a different commit message than the one used before.

Now, let's go back to the `main` branch by running `git checkout main` and open the `README.md` file. Notice how the modification we just made is not showing up. That's because that modification was only registered in the `develop` branch. If we now close the file, go to the `develop` branch again and reopen it, it suddenly appears.

We'll eventually finish the development of a new feature and, after testing it, we will want to merge the contents of the `develop` branch into the `main` branch. In order to do that, we need to run:
```
git checkout main # in case we are not in the main branch to begin with
git merge develop
```

The last command simply merges the content of the `develop` branch into the branch we are currently in (in this particular case, the `main` branch).

> [!IMPORTANT]
> With the concepts covered so far, one can already start using Git in projects, but it's important to emphasize that these are really just the basic concepts. For example, we haven't covered what may happen in case we want to merge two branches whose development has diverged over time.
>
> The good news is that Git is 20+ years old, so it's really easy to find resources on more advanced Git usage.

## GitHub/GitLab
After learning how we can do version control of our project, the natural next step is to understand how we can backup our project or share it with others or distribute it to different computers. Platforms like [GitHub](https://github.com/) and [GitLab](https://gitlab.com/) exist for this purpose.

> [!CAUTION]
> Google Drive and Git don't get along very well, so it's not a good idea to store a Git repository in Google Drive.

For this tutorial, we'll use GitHub just because that's where this website is hosted, although other platforms work in similar ways.

> [!WARNING]
> _Under construction_
