//s28379 Hw1 APBD Kahraman Berke Celenay
// Task 5: Merge was not fast-forward because independent commits were made on the main branch before merging the feature branch.

// 1. Fast-forward vs Merge Commit
// If main hasn't changed, Git just moves the pointer forward (fast-forward). If both branches have new commits, Git creates a "merge commit" to join them.

// 2. Merge vs Rebase
// Merge keeps all branch history and shows exactly where they joined. Rebase moves my work to the top of main to make the history look like a straight line.

// 3. Conflict Resolution
// I changed the same code on two branches, which caused a conflict. I opened the file, removed the <<<< markers, kept the correct code, and committed the fix.
