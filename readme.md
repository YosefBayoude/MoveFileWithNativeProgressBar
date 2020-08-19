# Project Title

Executable that allows to move files by renaming the path, including the native progress bar from Windows.

(Can be used in cmd)



## Getting Started

These instructions will get you a copy of the project up and running  on your local machine for development and testing purposes. See  deployment for notes on how to deploy the project on a live system.



### Prerequisites

dotnet core SDK



### Building

With `dotnet` installed run :

```bash
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true
```

This builds the solution in a single file.



## Running

Simply run the .exe and rename a file

```bash
MoveFileWithNativeProgressBar.exe "fileSourceLocation.txt" " fileDestinationLocation.txt"
```





## Built With

- Dotnet v.3.0