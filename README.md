# SELAB1
### Shayan Talaei 98109548 - Alireza Eiji 98101193

## Documentation
Here we provide a step-by-step documentation of our work.

1. Create a github repository named **SE_Lab_1** on the website.
![creating the repo](pics/1.png)

2. Clone the repository to the local.
![cloning the repo](pics/2.png)

3. Setting the protection rules for the *master* branch.
![setting protection rules](pics/3.png)

4. Check the current branch which is master. Create a new branch named *Add-minus*. Checkout to Add-minus branch. Check the current branch which is Add-minus.
![branching](pics/4.png)

5. Add all the created files to the stage area using `git add .` command. Commit the staged files with a given commit message.
![add files to the stage area then commit](pics/6.png)

6. Push the changes to the remote repository at Add-minus branch.
![push](pics/7.png)

7. Check the recently-pushed changes in the remote repository.
![pushed at remote](pics/8.png)

8. Checkout to the master branch. Pull the changes on the remote repo. As you can see, untracked files will be downloaded to the local.
![pull](pics/10.png)

9. Try to merge the branches. Nothing new will happen as the branch is already up to date.
![merge](pics/13.png)

10. Check the logs using `git log` command. It allows you to check the recent commits and their metadata.
![log](pics/15.png)

11. An example of conflict and resolving it. In conflicts, you need to choose the case which you want to keep.
![conflict](pics/confilt.png)

## Questions
1. ".git" folder is a hidden directory which gets created upon initializing a new git repository. It contains any information needed for interacting with the remote repository and logging the changes that happen on the local repo. Information for tracking the commits (version control), branches, and the config are stored in this folder within different folders with different meanings.
To create this folder, one can use `git init` command in the git bash environment or basically in their terminal.

2. In "atomic commits", the changes are very small and basically *indivisible*. These commits contain changes regarding a single (sub)task. It helps developers to make sure of their commits and whether the changes could be integrated with the database completely; if not they can rollback the commit. It also allows them to use seperate commits for refactoring and debugging for different tasks which makes the process much easier. To state some of the properties of an atomic commit, we can denote small incremental change, passed tests, and probably no TODOs.
The term "atmoic pull-request" refers to the pulls which are concerenced on a specific functionality. In these request one asks for the updates on a single target, which may combine some changes that happened on a branch while ignoring some of the irrelevant changes. All the changes get mixed as a single request and come to the local repo. In the case of conflict, no updates will happen on the local unless you resolve them first. 

3. Using `fetch` command, one can get a branch which is created on the remote repository but does not exist on the local repo. `merge` command allows you to merge the changes on a targeted branch with your current branch. You need to specify the targeted branch in your command, while the current branch is the one that the *head* is pointing to. `pull` command, on the other hand, helps you to download all the changes that have happened on your current branch on the remote repo to the same branch in your local. In case of conflict between with the changes on remote and your local you need to solve them before merging them together. 

4. Using git `reset` one can undo local changes to the state of a repository. It deletes the targeted changes. Git `revert`, on the other hand,  is a safe undo type commmand. It is a forward-mode approach meaning that instead of deleting the changes that happened so far, it creates a new commit that reverses the targeted changes. Using git `rebase`, one can move or combine some consecutive commits to a new base commit. It basically helps you to change to base of a branch in your repository. The command git `restore` allows you to unstage the files or basically undo what is happened by git add. It also helps you to discard the uncommited changes on the local repository. 

5. Before commiting the modified/untracked files, one need to put them in the *stage* positine. By adding the files to the stage position, you are telling git that you want to keep the track of these files in the next commit. It caches the files in a memory named index and makes them ready to be commited and pushed to the remote repository. 
Consider the scenario where you have made some untracked changes to a branch on your local and you want to switch to another branch. If you do that, all the changes would be lost as you did not save them anywhere. However, using `stash` command you can temporarily save the uncommited files and move between branches. Therefore, it allows you to switch between branches and work on different part of the project without the need for commiting the changes.

6. In git, *snapshot* refers to recorging the entire project and assigning a version to it. The snapshots are stored in the *.git* folder. A snapshot contains all the information of the files and directories up to a point in time which is created. So each commit is a snapshot of your project in time, containing all the changes with respect to its parent commit. A commit also keeps some metdata such as the author information and a commit message.
