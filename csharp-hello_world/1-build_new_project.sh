#!/usr/bin/env bash

#Bash script that initializes and builds a new C# project
#Create the folder 1-new_project
mkdir 1-new_project
#Navigate to the folder
cd 1-new_project
#Initialise with dotnet
dotnet new console
#Build 
dotnet build
