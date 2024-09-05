#!/usr/bin/env bash

#Bash script that initializes, builds, and runs a new C# project

#Create the folder 2-new_project
mkdir 2-new_project
#Navigate to the folder
cd 2-new_project
#Initialise with dotnet
dotnet new console
#Build 
dotnet build
#Run the project
dotnet run
