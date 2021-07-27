# Lab 6 - Rebasing

## Fork and rebase scenario

1. Create a fork from a public repository (use a fork from another course attendee)
2. Clone the forked repository
3. Add a remote to the source repository to your own local repository
4. Create a new branch *featurerebase*
5. Add multiple commits to the new branch
6. Check the commit history for the new branch

> Meanwhile, the original repository added some commits as well. To reduce conflicts with a pull request, and to make the commit history more clear, the new branch should be rebased on the latest commits of the source repository.

1. Fetch the latest commits from the source repository
2. Merge the commits in the master branch
3. Rebase the feature branch on the latest commits of the master branch
4. Check the commit history for the new branch

## Sqash scenario

Create multiple commits in your *develop* branch. Check the commit history. Change the history using the interactive mode of *rebase*: combine multiple commits to one commit. Push the changed history to the remote repository.

Use these commands:

* git rebase -i
* git log
