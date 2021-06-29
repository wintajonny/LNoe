
day2

# Markdown .md

# heading 1

## heading 2

...


*italic*
**bold**

* one
* two
* three

1. one
2. two
2. three
3. four

[my blog] (https://google.com)

![text] (link to image)

``` my CSharp code
public class Program
{
  static void Main(
    ....
}
```

Es gibt auch MarkDown extensions (funktionieren nicht überall)
- [] 17. Trick


# Guidelines

Entweder ein großes oder mehrere kleine

Mehrere kleine Vorteile:
- klares Ownership (wer ist verantwortlich)
- bessere Skalierung 

Nachteile:
- man erkennt das "Bigger Picture" nicht
- keine shared Komonenten

Großes repo Vorteile:
- code komplexität wird reduziert
- leichtes refactoring


# Fixing

## Cherry Picking

Pick commits from branches instead of the complete branch

Wenn nicht alles sinnvoll ist aber einige commits doch wichtig sind können sie herausgepickt werden
```
git cherry-pick "commit"
```


## Undoing
Wenn im commit zb. eine Datei vergessen wurde

```
//Add some things to previous commits (or change commit message)
git commit -amend -m "new message"

//Unstaging
git reset HEAD stagedfile

//Unmodifying a modified file
//git checkout --modifiedfile
git restore filename

// Undo local commits
git reset Head~2 //undo last two commits, keep changes
git reset --hard HEAD~2 //discard changes mit -- hard

//remove a file from git, but not from the filesystem
git reset filename
echo filename >> .gitignore

//add a forgotten file
git add forgottenfile
git commit --amend

//revert pushed commits           //sollte vermieden werden
git revert c4711c
```

## Submodule
Wenn andere Projecte in einem repo verwendet werden

```
git submodule add "linktorepo"


//clone submodules from a repo
git clone --recurse-submodules mainproject
git submodule update--init (if recurse-submodule was not used)
```

# Git Large File Storage (LFS)
für größere dateien (binärdateien)

```
git lfs install

git lfs track "*.psf"

git add .gitattributes

```

# Virtual File System for Git

zwischengelagert zwischen git command und file system 
lädt nur dateien herunter, welche gebraucht werden

macht nur bei größeren repositories sinn




# Github Desktop

# Github in Visual Studio





# Git Hooks
trigger actions at certain points in git's execution
Folder: .git/hooks  //da sind einige samples



# Visual studio integration

























































