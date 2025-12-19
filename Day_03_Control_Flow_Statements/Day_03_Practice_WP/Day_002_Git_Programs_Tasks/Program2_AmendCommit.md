
---

##  `Program2_AmendCommit.md`

```md
# Program 2: Undo Last Commit Without Losing Code

## Objective
To correct the last commit message without losing code and without creating a new commit.

## Steps Performed

1. Created a `UserService.cs` file.
2. Committed the file with an incorrect commit message.
3. Used Git amend to correct the commit message.

## Git Commands Used
```bash
git add UserService.cs
git commit -m "Added file"
git commit --amend -m "Add UserService class"
