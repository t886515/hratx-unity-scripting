# floppybird-sprint
Create a flappy bird clone using Unity, scripting in C#.

## First steps
  - The first thing you will need to get started on this sprint is a free Unity account. [Navigate to this link to set that up](https://id.unity.com/en/conversations/10aa47f9-04d6-4268-bab8-5fead8407aa4012f)
  - Now that you have that created, go ahead and download the most current version of the Unity [Personal edition software](https://store.unity.com/download?ref=personal)
  
  Now that you have done those things you can go ahead and fork this repo, and start working from your forked copy.
  
#### *NOTES*
Keep in mind you will not be building any textures, game art, or assets for this project. You are more than welcome to if you desire, but the ultimate goal of this sprint is to use the already loaded assets that I've provided ([via the Unity assets store](https://www.assetstore.unity3d.com/en/)) and learn the fundementals of scripting in C# with unity.


You will need to add a line to your ```.gitignore``` that looks like this: ```floppyBird/Temp/UnityLockfile```

## Adding the game objects
If the scripts of a game are the functionality or the brain behind how everything works, then the game objects are the rest of the body that is ultimately responsible for making your game interactive. Another the way to think of this relationship is like the MVC relationships you see of front end frameworks in web development. The game objects are most closely related to the view, the components have their equivalent counter-part called... *components*, and the model is the single source of truth embedded in the game scripts.
