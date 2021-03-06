# Generate your documentation with DocFX

[![devstatus](https://docfx.visualstudio.com/docfx/_apis/build/status/docfx-gated-checkin-CI)](https://docfx.visualstudio.com/docfx/_build/latest?definitionId=2)
[![Join the chat at https://gitter.im/dotnet/docfx](https://badges.gitter.im/dotnet/docfx.svg)](https://gitter.im/dotnet/docfx?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Github All Releases](https://img.shields.io/github/downloads/dotnet/docfx/total.svg?maxAge=600)](https://github.com/dotnet/docfx/releases/latest)

DocFX makes it extremely easy to generate your developer hub with a landing page, API reference, and conceptual documentation, from a variety of sources.

## Quickstart

Install DocFX and deploy a sample documentation web site:

1. Open a console.
2. Enter the following commands to install DocFX and build/deploy a sample site:

   ```
   choco install docfx
   docfx init -q
   docfx docfx_project\docfx.json --serve
   ```

3. Go to https://localhost:8080 to view the sample DocFX site.

For more information, refer to [Getting Started](http://dotnet.github.io/docfx/tutorial/docfx_getting_started.html).

## DocFX project

### Build the DocFX solution

To build the DocFX binaries from the Visual Studio solution:

1. Install [Visual Studio 2019](https://www.visualstudio.com/vs/) with *.NET Core cross-platform development* toolset
2. Install [Node.js](https://nodejs.org)
3. Build the solution using one of the following options:

   - Option 1: Console 
      - Open a DOS console and navigate to your DocFX clone subdirectory.
      - Run `build.cmd`.
   - Option 2: Visual Studio
      - Open a PowerShell console and navigate to your DocFX clone subdirectory.
      - Run `./UpdateTemplate.ps1` to generate the template files required by the Visual Studio solution.
      - Open the `docfx.sln` solution in your DocFX clone subdirectory from Visual Studio and build it.

### Build Status

`dev` is the default branch accepting Pull Requests. It releases a package daily. `main` branch is the release branch.

| main | dev
| - | -
| [![Build Status](https://ceapex.visualstudio.com/Engineering/_apis/build/status/Docs.Build/docfx-v2-master-release?branchName=master)](https://ceapex.visualstudio.com/Engineering/_build/latest?definitionId=1503&branchName=master) | [![Build Status](https://ceapex.visualstudio.com/Engineering/_apis/build/status/Docs.Build/docfx-v2-dev-release?branchName=dev)](https://ceapex.visualstudio.com/Engineering/_build/latest?definitionId=1743&branchName=dev)

### Install packages

| Chocolatey | Nuget
| - | -
| [![Chocolatey](https://img.shields.io/chocolatey/v/docfx.svg)](https://chocolatey.org/packages/docfx) | [![NuGet](https://img.shields.io/nuget/v/docfx.svg)](http://www.nuget.org/packages/docfx/)

### Running Status

| Windows with VS2017 | Ubuntu Linux with Mono
| ------------- |----------
| [![VS](https://docascode.visualstudio.com/_apis/public/build/definitions/c8f1f4cb-74cb-4c89-a2db-6c3438796b0a/2/badge)](https://docascode.visualstudio.com/docfx/_build/index?context=mine&path=%5C&definitionId=2&_a=completed)|[![Ubuntu](https://travis-ci.org/docascode/docfx.test.svg?branch=master)](https://travis-ci.org/docascode/docfx.test)

## How to Contribute

For new comers, you can start with issues with **[`help-wanted`](https://github.com/dotnet/docfx/labels/help-wanted)**. Check out the [contributing](.github/CONTRIBUTING.md) page to see the best places to log issues and start discussions.

This project has adopted the code of conduct defined by the [Contributor Covenant](http://contributor-covenant.org/) to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](http://www.dotnetfoundation.org/code-of-conduct).

## License

DocFX is licensed under the [MIT license](LICENSE).

DocFX is supported by the [.NET Foundation](http://www.dotnetfoundation.org).

