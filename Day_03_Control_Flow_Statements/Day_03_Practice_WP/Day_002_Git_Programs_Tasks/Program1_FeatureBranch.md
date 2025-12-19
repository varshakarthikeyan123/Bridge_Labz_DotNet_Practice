# Program 1: Feature Branch Workflow (C# Project)

## Objective
To understand and implement a feature branch workflow using Git in a C# .NET Console Application.

## Steps Performed

1. Created a .NET Console Application using `dotnet new console`.
2. Initialized a Git repository and set the default branch to `main`.
3. Created a feature branch named `feature/calculator`.
4. Added a `Calculator.cs` file with Add and Subtract methods.
5. Committed the calculator functionality in the feature branch.
6. Switched back to the `main` branch and merged the feature branch.

## Git Commands Used
```bash
git init
git branch -M main
git checkout -b feature/calculator
git add Calculator.cs
git commit -m "Add calculator add and subtract methods"
git checkout main
git merge feature/calculator
