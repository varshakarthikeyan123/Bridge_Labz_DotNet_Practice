
---

## `Program3_GitStash.md`

```md
# Program 3: Git Stash in Real Scenario

## Objective
To temporarily save uncommitted work using Git stash, handle an urgent hotfix, and restore previous work safely.

## Steps Performed

1. Modified `OrderService.cs` without committing changes.
2. Stashed the uncommitted changes.
3. Created and switched to a hotfix branch `hotfix/order-null-fix`.
4. Fixed the bug and committed the changes.
5. Switched back to the original branch.
6. Restored the stashed changes.

## Git Commands Used
```bash
git stash
git checkout -b hotfix/order-null-fix
git add OrderService.cs
git commit -m "Fix null order issue"
git checkout main
git stash pop
