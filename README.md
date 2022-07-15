# MiniBug v2 - Issue Tracker and To-do List

This is a fork of MiniBug for VS2019 and .NET 4.8.

Some of the changes:
- Removed missing MiniBug_TemporaryKey.pfx and signing from project
- Default fontsize set to 10
- Scale forms after changing fontsize in settings
- Load project on startup if only one project exists
- Optionally attach an image to an issue
- Create single exe using Fody.Costura
- Show a ModernUI.Charting pie chart after loading a project
- Copy issue and image to Clipboard
- Search issue
- Create PDF from issue



MiniBug is a barebones, simple issue tracker and to-do list. It is a Windows desktop single-user application.

<img src="Screenshots/main-window.png" alt="MiniBug main window">

MiniBug does not use a database to store data: instead the application stores each project in a .json file. This means that if you need to work on projects, in different computers, you can share a MiniBug project between computers, by putting the .json file in something like Dropbox.

Attached images are stored with their file name only, it is recommended to keep them in the same folder as the application.
Preferably keep images in a subfolder "Images", this way all data can be copied easily to another location.

<img src="MiniBug/Resources/Clipboard_64x64.png" alt="Clipboard button">

When using the "Copy to clipboard" button, text and images can be pasted into office applications by using "Paste special".

## Features

- Issues: create, edit, delete, clone
- Tasks: create, edit, delete, clone
- Show/hide/sort columns
- Some user defined settings
- Export issues and tasks to CSV format

## Sample project

You can try a small sample project, with bugs and tasks copied from some applications' public bug trackers (Inkscape, Firefox, MariaDB and Kodi).

Download the file <a href="MiniBug Sample Project.json">MiniBug Sample Project.json</a> and open it in MiniBug.

## Benchmarks

MiniBug v2.5.5 compiled with .NET 4.8 versus .NET 6.0.
A comparison of speed differences loading a test project of 4000 issues on a Windows 10 PC with an SSD gave the following results:

.NET 4.8 from VS2019
- Loaded project in 1,2707805 seconds
- Reloaded project in 1,786954 seconds

.NET 6.0 from VS2022
- Loaded project in 1,0638802 seconds
- Reloaded project in 1,3707548 seconds

.NET 4.8 exe
- Loaded project in 1,0807529 seconds
- Reloaded project in 2,2314549 seconds

.NET 6.0 exe
- Loaded project in 0,8620784 seconds
- Reloaded project in 1,7411413 seconds

As the .NET 6.0 speed improvement is not very significant, and the executable is much bigger and not as neatly packed into a single exe, I decided to not publish this version on GitHub for the time being. Also the .NET 6.0 version is not cross-platform, it is purely a Winforms application, so that is no argument to port it either.

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
- <a href="https://www.codeproject.com/Articles/5299801/A-Control-to-Display-Pie-and-Doughtnut-Charts-with">Pie chart control</a>: by Angelo Cresta
- <a href="https://www.codeproject.com/Articles/570682/PDF-File-Writer-Csharp-Class-Library-Version-2-0-0">PdfFileWriter library</a>: by Uzi Granot
- <a href="https://github.com/Fody/Costura">Fody.Costura</a>: for creating a single exe

<a target="_blank" href="https://icons8.com/icon/EQ4HGAcEI0hH/chart">Chart</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>

<a target="_blank" href="https://icons8.com/icon/9u9JUlsiUlgh/clipboard">Clipboard</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>

<a target="_blank" href="https://icons8.com/icon/57857/pdf">PDF</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
