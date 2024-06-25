# CF.Bonsai

This repository contains Bonsai workflows examples for [Bonsai](https://bonsai-rx.org/) created at the Champalimaud Foundation. These workflows are used to demonstrate the capabilities of Bonsai and to provide examples for users to build their own workflows.

It contains some utility packages for Bonsai and has support assets that were used in the different courses and workshops that were given at the Champalimaud Foundation.

The repository is organized in the following way:

- `docs`: Contains the documentation for the repository, including the Bonsai workflows under the `workflows` folder.
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

## Prerequisites

- [DocFx](https://dotnet.github.io/docfx/)
- [Node.js](https://nodejs.org/) (optional for automatic documentation generation)

> [!IMPORTANT] 
> If you use Node.js, you can install the dependencies by running the following command at the `docs` folder:
> ```bash
> npm install
> ```

## Documentation

The documentation is written in Markdown and is available under the `docs` folder. The documentation is built using [DocFx](https://dotnet.github.io/docfx/).

If you have Bonsai workflows, please add them to the `docs/workflows` folder and reference them in the documentation. You can create subfolders to organize the workflows if you wish.

Under the `docs` folder, you will find the following structure:
- `index.md`: The main page of the documentation.
- `toc.yml`: The table of contents for the documentation.
- `articles`: The folder containing the documentation articles.
- `articles/toc.yml`: The table of contents for the documentation.
- `workflows`: The folder containing the workflows.
- `workflows/toc.yml`: The table of contents for the workflows.

## Local Development

If you want to build the documentation locally, you need to understand the three steps involved in the documentation generation.

1. Setup local Bonsai installation (only required to do once).
2. Convert the Bonsai workflows to SVG images.
3. Build the documentation using DocFx.

The first step is automated using a Powershell script. The script is available under the `.bonsai` folder with the name `Setup.ps1`.

> [!NOTE] 
> This is only required to be done once.

You can run the script using the following command, while at the `.bonsai` folder:

```powershell
.\Setup.ps1
```

The last two steps are automated using a Powershell script. The script is available under the `docs` folder with the name `build.ps1`.

> [!IMPORTANT]
> This is required to be done every time you add new Bonsai workflows to the repository.

You can run the script using the following command, while at the `docs` folder:

```powershell
.\build.ps1
```

If you don't have new workflows to be converted, you can save time by generating the documentation manually by following running the following command while at the `docs` folder.

```powershell
docfx --serve

# or if you have Node installed
npm run docfx
```

The documentation will be available at [http://localhost:8080](http://localhost:8080).

> [!CAUTION]  
> The documentation will only be updated automatically if you have NodeJS installed.

If you want to update the documentation, you will need to stop the server and run `docfx --serve` again.
