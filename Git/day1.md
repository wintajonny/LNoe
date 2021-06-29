# GIT

## Git Configuration

git config --global user.name "wintajonny"
git config --global user.email thomas.winter0211@gmail.com"

git config -global init.defaultBranch main

git config -l --global                            //zeigt alle configurationen

## Für Hilfe

git --help
git <command> --help
//bei -h (statt --help) wird es in der console angezeigt


# States

git init im folder erstellt ein .git

## Untracked
noch nicht geadded

## Tracked
geadded aber noch nicht committed



## Best Practices

- oft committen
- bevor die commits auf den server gespeichert werden kann man rebase/squash verwenden

- keine binären Dateien ins repository


# Git Ignore
Dateien welche nicht ins repo sollen ins .gitignore schreiben
(github.com/github/gitignore)



git diff

#Viewing Commit HIsory
git log
        -p                        //zeigt changes an
        -p -2                     //zeigt die letzten zwei logs und deren changes an
        -stat                     //zeigt dateien mit infos an (geänderte zeilen)
        -pretty=format:"%h - %an. %ar : %s"   //zeigt eine schönere version vom log an


git add "file"
//undo
git restore --staged "file"

Lab1


  
git diff --cached
git diff <commit id1> commit id2>
  
  

# Delta Based vs Snapshot  
bei delta werden die änderungen gespeichert
bei Snapshots werden die ganzen dateien neu gespeichert


# Lokales repository mit remote repo verknüpfen
  
  //add remote repository
git remote add origin "url"
  //push changes to the remote repository
git push -all origin
  //configure to use the remote repository with pull and push
git push --set-upstream origin main
  

# Clone a repo

git clone "repo"


# Push und Pull

push: änderungen aufs remote repo speichern
fetch: holt sich alle änderungen vom remote in die git datenbank, bringt sie aber nicht ins Verzeichnis rein
pull: fetch + update im working directory

git remote show origin: information zum remote origin

# Multiple remotes

git remote -v: zeigt alle remotes
git remote add "name" "url"

Lab02

# Tagging

git checkout "commit id"

git switch main

Mit Tags können Commits markiert werden

git tag: alle tags anschauen

Lightweight Tags:
alias auf eine commit id

git tag 1.4-lw

Annotated Tag:
git tag -a v1.4 -m "my Version 1.4"
Wird ein eigenes Objekt erzeugt mit einer commit message

Tags nach dem commit

##Pushen von einem Tag
Tags sind anfangs nur lokal

git push origin v1.5
git push origin --tags: alle tags

Best practices:
- wichtige zeitpunkte taggen (versionen)
- annotated tags geben mehr information (wer, wann, message)
- Release branches können statt annotations erstellt werden (geschmackssache ob tags oder branches)


# Branching

Head: wo man sich gerade befindet
bei checkout "commit id" : detached Head

git branch: zeigt alle branches

## Branch erstellen
git branch testing
//Head zeigt auf testing
git switch testing (zwischen branches)
(oder) git checkout testing (bei tags, commits oder branches)

//alle branches werden angezeigt mit abzweigungen
git log --oneline --decorate --graph --all

## Branch merging
git switch main
git merge testing

git push

## Merge Konflikte

git merge feature1
//conflict message

git status
//both modified
//datei ändern und konflikte beheben

git add .
git commit -m "resolved merge conflict"

## Remote Branches
Schnell Zugriff auf eine bestimmte commit id (Bookmarks)

git push --set-upstream origin testing

## Pushing, Fetching, Pulling

git push (remote) (branch)
git push origin feature1

git fetch origin

git pull (remote) (branch)

Best Practices:
- oft branchen
- oft mergen
- main branch protecten (nur in zweigen arbeiten, gar nicht erlauben im main branch zu pushen sondern nur über pull requests)

## Rebase
Bei einem Merge werden alle commits (history) erhalten
Bei einem Rebase wird die history überschrieben

!! nie bei public branches rebasen

bei merge wird ein neuer commit mit beiden branches gemacht
bei rebase wird die basis des branches geändert 
git rebase main topic

## Squashing von Branches
Merge commits in a single commit

git rebase -i


# Distributed Git

## Zentralisierter Workflow:
einige lokale repos auf ein remote repository

## Integration manager workflow
project maintainer pushes to public repo

entwickler können nicht ins "blessed repo" pushed, sonder jeder hat sein eigenes public repo
die changes werden vom integration manager übernommen und ins blessed repo geschrieben


## Forking a repository
kopie von einem repo wo man keine schreibrechte hat 
änderungen dann mit pull request ins original speichern


## Git branches:

git flow init

### Feature Branch

git flow feature start myfeature1

git checkout -b christian/feature1 develop

### Release Branch


### Hotfix Branch
für Probleme 


















 





