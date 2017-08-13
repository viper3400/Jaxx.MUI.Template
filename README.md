# Jaxx.MUI.Template

## Introduction
This is a quickstart template solution (Visual Studio 2017) for getting started with
[FirstFloor ModernUI WPF](https://github.com/firstfloorsoftware/mui) and the 
[MVVM Light Toolkit](http://www.mvvmlight.net/). This template was setup using the step by step guide provided at
[Guy Startbucks Blog](https://weblogs.asp.net/guystarbuck/mvvmlight-and-modernui-part-1-setup). Instead of using the 
SimpleIoC functionality which comes with MVVM Light this template uses [Autofac](https://autofac.org/).

**This is just a template and spares you wire up the components each time. For getting started with the basics of the names components refer to their documentation.**

## Getting started
### Step by step
1. Clone ore download this repository
2. Copy complete solution folder of Jaxx.MUI.Template
3. Rename solution folder to desired project name
4. Remove sub directories “.git” and “.vs” (if applicable)
5. Rename the solution file
6. Rename project (csproj) file in project folder
7. Rename project folder under /src
8. Remove bin and obj folder in project folder (if applicable)
9. Replace string “Jaxx.MUI.Template” in all files with new name (i.e. with Notepad++) 
10. Open solution in VS
11. Create new git repo in new solution folder
12. Initially commit into repo

### Automated / scripted setup

The powershell script (RenameSolution.ps1) you can find in solution folder is a first try to automate some of the steps
above.

* Perform steps 1 to 3.
* Run the RenameSolution.ps1
* Run steps 10 to 12.

As new name the script will gather the name of the solution folder you've provided in step 3.

**This script is still work in progress. If it won't work out for you start again from step 1 or 2.**

#### Problems running the Powershell script
If you are unfamiliar with Powershell you may have problems running the script because of the default setting 
of [Powershells Execution Policy](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about_execution_policies?view=powershell-6).
By default it is set to "Restricted" which prevents running of all script files.

To workaround this:
* Press WINDOWS KEY + R (Windows "Run" dialog appears)
* Type "powershell.exe -executionpolicy unrestricted" and run
* CD into your new solution folder and run ".\RenameSolution.ps1"

# Credits 
* https://autofac.org/
* https://github.com/firstfloorsoftware/mui
* http://www.mvvmlight.net/



