# CF.Bonsai

This repository contains Bonsai workflows examples for [Bonsai](https://bonsai-rx.org/) created at the Champalimaud Foundation. These workflows are used to demonstrate the capabilities of Bonsai and to provide examples for users to build their own workflows.

It contains some utility packages for Bonsai and has support assets that were used in the different courses and workshops that were given at the Champalimaud Foundation.

The repository is organized in the following way:

- `docs`: Contains the documentation for the repository.
- `workflows`: Contains the Bonsai workflows.
- `courses`: Contains the assets used in the courses and workshops.
- `packages`: Contains the utility packages for Bonsai.

## Publishing the Documentation

The documentation is published to [GitHub Pages](https://pages.github.com/) by a GitHub Action and is available at [https://fchampalimaud.github.io/CF.Bonsai/](https://fchampalimaud.github.io/cf.bonsai/).

> [!CAUTION]  
> The GitHub Action is triggered by a push to the `main` branch and it will build the documentation and publish it to the `gh-pages` branch. **The documentation will be overriden by the latest build**.

> [!NOTE]  
> It can also be triggered manually on the Actions page.

# Contributing

The repository is open for contributions. If you want to contribute to the documentation, please follow the guidelines below.

## Guidelines

1. Fork the repository.
2. Create a new branch.
3. Make your changes.
4. Push the changes to your fork.
5. Create a pull request.

## Documentation

The documentation is written in Markdown and is available under the `docs` folder. The documentation is built using [DocFx](https://dotnet.github.io/docfx/).

If you have Bonsai workflows, please add them to the `workflows` folder and reference them in the documentation. You can create subfolders to organize the workflows if you wish.

Under the `docs` folder, you will find the following structure:
- `index.md`: The main page of the documentation.
- `toc.yml`: The table of contents for the documentation.
- `articles`: The folder containing the documentation articles.
- `articles/toc.yml`: The table of contents for the documentation.

## Local Development

If you want to build the documentation locally, you can follow the steps below.

1. Install [DocFx](https://dotnet.github.io/docfx/).
2. Clone the repository.
3. Navigate to the `docs` folder.
4. Run `docfx --serve`.

The documentation will be available at [http://localhost:8080](http://localhost:8080).

> [!NOTE]  
> The documentation won't be updated automatically when you make changes to the Markdown files.

If you want to update the documentation, you will need to stop the server and run **step 4** again. 

As an alternative, if you have Node installed, you can run `npm run docfx` to start the server.

For that you will need to:
- Install Node.js from [https://nodejs.org/](https://nodejs.org/) (or use a nodejs manager such as [nvm](https://github.com/nvm-sh/nvm)).
- Run `npm install` to install the dependencies.
- Run `npm run docfx` to start the server.