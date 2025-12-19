
---

##  `Program4_MergeConflict.md`

```md
# Program 4: Resolve Merge Conflict (C#)

## Objective
To understand and manually resolve a merge conflict in a C# file.

## Steps Performed

1. Created two separate branches modifying `PaymentService.cs`.
2. One branch added a null check for payment.
3. Another branch modified the return logic.
4. Merged both branches into main, resulting in a merge conflict.
5. Manually resolved the conflict by combining both validations.
6. Committed the resolved code.

## Final Logic Implemented
```csharp
if (payment == null) return false;
return payment.Amount > 0;
