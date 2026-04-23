# GDIM 33 In-Class Activities
## W1
### Activity 1
[Mood Board Link](https://miro.com/app/board/uXjVGoFIqU0=/?share_link_id=382795715347)
1. The main pattern emerging from my inspiration sources is time/causality interference abilities from various video games and stories. I'm interested in creating a puzzle/tactical game where the user is capable of manipulating cause and effect (likely in the form of time). The images also show my interest in either a top-down 2D pixel-art style or a 2D sidescoller game.
2. While everyone else at my table plans to build a 3D rather than 2D vertical slice, one other person plans to make a puzzle game wherein the player must contend with unusual abilities (sensory manipulation). Another person at my table was inspired by the retro-futurism of Cowboy Bebop, which is one of my favorite television series of all time. 
3. My LA, Eric, has a taste in video games nearly diametrically opposed to mine. He prefers multiplayer FPS games. I prefer singleplayer 3rd person games that generally don't involve real-time gunplay. However, Eric did mention Deep Rock Galactic, a 3rd person fantasy-meets-technology game which I have seen footage of, and it seems quite fun. 


### Activity 2
<img width="943" height="708" alt="234567890" src="https://github.com/user-attachments/assets/479fea29-d86f-4cc3-be44-28a6b9cd26f8" />


## W2
Write your W2 Devlog here.

Continue adding additional headers below this one for future weeks and future activities.

## W3
### Activity 1
<img width="1728" height="1440" alt="GDIM 33 Game Breakdown (1)" src="https://github.com/user-attachments/assets/b4ee4f79-bcc8-40cb-9bd3-1fc3e8a6d7f5" />

### Activity 2
1. By saving the event name as a Scene variable, the event can be activated from any gameObject in the Scene which has a reference to the gameObject containing the event. If the event name were to change, all objects activating the event would still be able to activate it, as they are storing a reference to the variable containing the name, not the name itself. Saving the event name as a scene variable allows the event to be activated from more gameObjects and improves the program's resiliency.
2. The Debug.Log nodes for my mouse click and the explore --> dialogue transition let me know that the state transition was broken, as the only the Debug.Log for my mouse click appeared. I knew that the problem was with activating the transition event rather than with how the program handles mouse inputs.
3. The Set Cursor Lock State is not relevant to my vertical slice. The player's camera is tied to their position, not their cursor, and the player will constantly be moving their cursor to activate abilities. I do not see any scenario in which the cursor ought to be locked.
4. My vertical slice will likely have 2 game states: class selection and combat. Everything will be frozen during class selection as the player chooses their character, and everything will be enabled and unfrozen during the combat state.

## W4
### Activity 1
Currently I have 3 player classes, each with 1 out of 2 abilities implemented. The boss contains a state machine graph three phases and 9 attacks. Ghost replay for players is working with (I believe) physics frame perfect precision. Past player incarnations move and attack exactly as the player originally did. The boss can infect players with a plague which spreads upon death, raising zombies from dead players. Zombies generally copy the player's class abilities. There is no music or audio or VFX. 
My playtest goal is to find out just how overtuned the boss currently is. Currently the boss has >10x the HP of the tankiest player class, and I have not been able to defeat it once, even with over 20 past incarnations helping me. Even after repeated nerfs, I believe the boss's movement patterns & stats should still be revised. 

### Activity 2
