# Basic MVVM

MVVM Toolkit template for .NET 5 Desktop with DI and other basic stuff.

## Installing / Getting started

Copy the MVVMToolkitNET5.zip file from Releases page into the user project template directory. By default, this directory is ```%USERPROFILE%\Documents\Visual Studio <version>\Templates\ProjectTemplates```.

### Initial Configuration

After creating project from template edit two files in **WPF** project for your needs: **appsettings.json** (serilog section and UpdateUrl path for updater, for example, full path to ```SolutionDir\Deploy```) and **ReleaseSpec.nuspec** (copyright, authors, description).

## Features

- Easy setup for new project with basic needs
- Navigation system
- Following MVVM Design Pattern
- [Serilog](https://github.com/serilog/serilog) - Logging
- [Squirrel](https://github.com/clowd/Clowd.Squirrel) - Updater
- [Microsoft.Toolkit.Mvvm](https://github.com/CommunityToolkit/dotnet) - MVVM Toolkit
- [WPFLocalizeExtension](https://github.com/XAMLMarkupExtensions/WPFLocalizeExtension) - Localization
- Dependency Injection with Microsoft.Extensions.DependencyInjection
- Project publish, pack and release using [Squirrel flow](https://github.com/clowd/Clowd.Squirrel/blob/develop/docs/readme.md)

## Licensing

[MIT License](https://github.com/FoxPride/BasicMVVM/blob/master/LICENSE)