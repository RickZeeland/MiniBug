# MiniBug - Issue Tracker and To-do List

This is a fork of MiniBug for VS2019 and .NET 4.8.
Some of the changes:
- Removed missing MiniBug_TemporaryKey.pfx and signing from project
- Default fontsize set to 10
- Scale forms after changing fontsize in settings
- Load project on startup if only one project exists
- Optionally attach an image to an issue
- Create single exe using Fody.Costura, https://github.com/Fody/Costura
- Show a ModernUI.Charting pie chart after loading a project



MiniBug is a barebones, simple issue tracker and to-do list. It is a Windows desktop single-user application.

<img src="Screenshots/main-window.png" alt="MiniBug main window">

MiniBug does not use a database to store data: instead the application stores each project in a .json file. This means that if you need to work on projects, in different computers, you can share a MiniBug project between computers, by putting the .json file in something like Dropbox.

## Features

- Issues: create, edit, delete, clone
- Tasks: create, edit, delete, clone
- Show/hide/sort columns
- Some user defined settings
- Export issues and tasks to CSV format

## Sample project

I've made a small sample project, with bugs and tasks copied from some applications' public bug trackers (Inkscape, Firefox, MariaDB and Kodi).

Download the file <a href="MiniBug Sample Project.json">MiniBug Sample Project.json</a> and open it in MiniBug.

# Getting Started

## Prerequisites

- Microsoft Windows 7 or higher
- Microsoft .NET Framework 4.8

# How To Use

First you need to create a new project (File > New Project), define a project name and choose a location to save it:

<img src="Screenshots/new-project.png" alt="New project window">

Next you can start adding issues and tasks:
- issues are bugs/problems
- tasks are items in a to-do list

## Issues

<img src="Screenshots/issue.png" alt="Edit issue">


## Tasks

<img src="Screenshots/task.png" alt="Edit task">

## Settings

The user can modify some settings (File > Settings) in order to customize the look and feel of the application:

<img src="Screenshots/settings.png" alt="Edit settings">

Settings in action:

<img src="Screenshots/settings.gif" alt="Edit settings">

## Sorting

You can sort the grid rows in two ways:

- by clicking on a column header:

<img src="Screenshots/sort1.gif" alt="Sort rows (first method)">

- by using the **Configure Columns** window:

<img src="Screenshots/sort2.gif" alt="Sort rows (second method)">

Using the second method you can sort by up to two columns and with different criteria (ascending or descending).

## Column visibility

You can show/hide any column (except the **ID** column, which is always visible), using the **Configure Columns** window:

<img src="Screenshots/visible-columns.gif" alt="Show/hide columns">

## Exporting

You can export a project's issues and tasks to CSV (comma separated values) files:

<img src="Screenshots/export.png" alt="Export project">

Because issues and tasks have a slightly different structure, they are exported to separate files. If a project only has issues or tasks, only one file will be generated:

<img src="Screenshots/export2.png" alt="Export project only with issues">

# License

This project is licensed under the MIT License - see the LICENSE.md file for details.

# Acknowledgments

This project uses the following libraries:

- <a href="https://www.newtonsoft.com/json">Json.NET</a>: for reading/writing to .json files
- <a href="https://joshclose.github.io/CsvHelper/">CsvHelper</a>: for exporting to CSV

Chart icon by Icons8: <a target="_blank" href="https://icons8.com/icon/EQ4HGAcEI0hH/chart">Chart</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>