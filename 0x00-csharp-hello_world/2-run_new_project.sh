#!/usr/bin/env bash
dotnet new console -o 2-new_project --force
cd 2-new_project
dotnet build
dotnet run