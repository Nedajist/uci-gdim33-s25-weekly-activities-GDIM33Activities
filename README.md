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

Playtest Notes: The boss has too much health. One playtester did not even notice the boss had a healthbar because it changed so little from attacks. Its movement speed is also too fast, effectively being able to permanently push player characters during its later phases. Maybe the boss should stop or slow once it is within melee distance of its target. The boss's charge attack is still bugged, and its speed value increases to over 50 when it should never be over 10. I will significantly nerf the boss. 

### Activity 2
1. A writer could add more dialogue without writing any code by creating DialogueLineW4 scriptableobject nodes and copy/pasting dialogue into its line and reply options fields. Then they could link lines of dialogue by dragging other line nodes in the reply options section. None of this requires writing code.
2. A writer could create a theoretically infinite number of dialogue node scriptable objects without scripting, although they would eventually be limited by their computer's storage capacity.
3. Regenerate nodes refreshes the types of nodes the player is able to create in visual scripting graphs. It is typically used when the programmer creates a new class/method in C# scripts and wants to be able to use them in visual scripting. When new classes/methods are made, Unity doesn't automatically add them as visual scripting nodes, so the player must regenerate them. 

## W5
### Activity 1
I have implemented my chosen Unity tool (scriptable objects) and all of my non-VFX vertical slice features, so I will work on improving enemy NPC behavior and presentation. 
Steps:
1. Make healthbar of enemies more responsive.
	1. Make a central healthbar prefab shared across all characters, instead of characters each having their own distinct healthbar gameobject. I will know it works if, after adding the prefabs to each character, the healthbars still function as before. 
	2. Add a black background behind each healthbar so the player can better visualize the amount of missing HP from an enemy. If I can see the black backgrounds behind each health bar, it works. 
	3. Make a coroutine which expands, then shrinks, the size of a healthbar when health changes. If I can see the healthbar scales changing while playing, its functional. 
2. Make enemies avoid colliding into each other, which results in friendly-fire collision damage. 
    1. Add a method to the enemy script which executes a physics circlecast and returns a list of all NPCs caught within it. I'll test this by running a debug.log on the returned list and by having enemies spawn close to each other. 
	2. Create a method, which, when given a gameobject, creates a normalized vector2 pointing from the gameobject to the enemy NPC. I will debug.log the Vector2's to ensure that they are correct. 
	3. Modify the previous method to make the vector2 apply a small force to the enemy in the direction of the Vector2. I'll know its working when I see enemies invisibly push each other apart as they clump together. 

### Activity 2
I have finished adding a healthbar shake method and have changed all of the healthbar gameobjects into a single healthbar prefab. When a player or non-boss NPC takes damage, their healthbar will shake, its scale increasing then decreasing. I've decided to not shake the healthbar upon receiving healing, as healing is received every frame. I can adjust the change in scale and the time it takes for the healthbar to grow and shrink for each NPC. 
Enemy avoidance is also complete. Enemy mages, healers, and tanks will now avoid running into other characters if they get too close. Enemies only avoid characters who are not their current target. This works with multiple nearby NPCs in different directions. 

## W6
### Activity 1
Each of the three original classes (square, triangle, circle) now have their second ability. Square can dash, triangle applies an AOE slow, and circle can summon a stationary turret. I added a fourth class, pentagon, with 2 abilities. It fires a projectile which pulls it and the target together and another projectile which pushes them apart. A character's healthbar now shakes when they receive damage. Enemies will now try to avoid colliding into each other. The boss's HP and attack patterns have been slightly reworked. 

[Itch page link](https://omnomnom8.itch.io/v2)

Playtesting goals: I want to see if the reworked boss fight is significantly easier than the previous playtest fight while still providing a challenge to the player. I would also like to see if the new class abilities are interesting and intuitive, especially since the player will not receive a tutorial. If the boss is beatable, I will gauge its difficulty by finding out the average # of deaths it takes to defeat it. 

Playtesters: Kai, Nathan, Marcelo

Playtest notes: Even after nerfing the boss's health by almost 50%, no playtester was able to get the boss's health below half. Even after 20+ deaths (and thus 20+ past incarnations helping me via ghost replay), I was unable to get the boss's heathbar to reach 50%. I will continue nerfing it until the player can beat it within 30 deaths. However, all playtesters found the abilities to be enjoyable, and they were mostly understood without any explanation. 

### Activity 2
1. The multiply setting makes the resulting color darker, as the new RGB values will always be darker or as dark as the input color values. Since the RGB values are stored between 0-1 and a lower value means a darker color, unless both R, G, or B are set to 1 or 0, the resulting multiplication between two decimal values will always result in a smaller decimal value, which is a darker color.  

2. The resulting a value will almost always be more translucent than either of the original values. As with blending RGB values, a-values are stored between 0-1, and smaller a-values means more translucence. Unless the two input a-values are 0 or 1, two decimals between 0-1 are multiplied against each other, always resulting in a smaller decimal and a more translucent shade. If both a-values are 0 or 1, the translucence won't change since 0 * 0 = 0 and 1 * 1 = 1.

3. I think the shader gets its UV values from the vertices of the mesh that it is attached to, or perhaps from a preset list of defaults. 

4. It does sound interesting to me, as I think I'll be using shader graphs to create VFX for my vertical slice game. I don't think I want to exclusively focus on shader graphs in the future, but I'll definitely be using them in my next projects. 

## W7 
### Activity 1
1. The data for the Vertex Color node comes from the Vertice UV values in the shiba mesh. 
2. The color on our shiba is blended at the edges due to interpolation; the colors of all of the areas in between vertices are blended based on their distance from each vertex. 
3. The vertex color shiba is less detailed than the textured shiba because vertex color relies on the UV values stored in each shiba vertice, and because there are many more points on the shiba model than vertice points, the shiba relies heavily on interpolation to determine the colors of areas between vertice points. This blend is less precise than a texture, which covers every point on the shiba with a precise, unblended color. Vertex color is probably more useful for playtesting and games that use a high volume of models which need to optimize for efficiency. 
4. There is a patch on the shiba's left leg which is colored light green but is surrounded by blues. The surface normals in that area appear to be facing in the wrong direction. 
5. Position data can also be made into a debug shader. When applied, the developer can quickly tell whether or not a portion of a model is on a negative/positive x, y, or z axis and when the model changes axis. This might be useful in situations where the developer must keep track of the axis of many models at once, and relying on debug.log would result in too many simultaneous messages. 
6. The surface normals for that area of the shiba are pointing in the wrong direction, facing away from the re-adjusted lighting direction rather than towards it. The dot product between two opposite-facing vectors is negative, and a negative value results in a darker color. This results in a dark patch on the shiba which faces towards the light. 
7. I think we set the blending mode to additive in order to make the fire appear slightly brighter/glowing. Switching from alpha to additive seems to make the texture slightly more transparent and slightly lighter. 

## W8
### Activity 1
I've added bullet trail particles to every projectile as well as the square's dash. The fifth and final character class, the architect/painter, is now in the game. They can fire moving walls to block projectiles and enemies and build static walls using the mouse cursor. A zombie version of them is also functional. Finally, I've once more reworked the boss's stats and ability numbers, so hopefully it should be more balanced.

[Itch page link](https://omnomnom8.itch.io/1-v3)

Playtest goals: After nerfing the boss's health by 50% and reducing the damage of its attacks and buffing a variety of player classes and abilities, my main goal is to figure out if the boss is still too overtuned. I also want to see if playtesters can understand the new class's ability with no tutorial.

Playtesters: Ruichen, Alvin, Kai

Playtest notes: Unfortunately, the boss remains undefeated. Its guarantee-hit AOE in its third phase still catches players off guard, and players didn't understand how the infection mechanic works. However, they were able to use the new class perfectly, and they got the boss to around 30% health. Given that most of the playtesters this round haven't seen my game before, I think that a more experienced tester can likely defeat the boss. 

### Activity 2B
1. The fraction node animates the shine effect by getting a time input and outputting its decimal value. Because the decimal value of time oscillates between 0 and 1, the fraction's output will cycle between 0 and 1. That value is then added to every pixel of the sprite's UV, and because higher UV values are closer to white, the fraction is adding a cyclical shine to the sprite's UV.
2. The shine texture for the shader mus be black by default because we are adding a shine value to an un-shined texture. If the texture were already pure white, then it would already be shining at max brightness. Adding more to its UV would not change the texture at all, and we would not be able to darken it. 
3. The building texture in the graph isn't applied to the sprites that use it because the building texture is stored in MainTex. Unity reserves the Texture2D property MainTex and overrides it with the sprite from the spriterenderer. The chest sprite overrides the building sprite.
4. fraction(time * shinySpeed) ensures that the value added to the UV will be between 0-1. However, if shinySpeed is greater than 1, then shinySpeed * fraction(time) can result in values greater than 1 and larger values in general, since fraction isn't there to clamp the values at the end. This results in brighter UV values applied to the chest, making it become shiny faster and even shinier than intended.

## W9
### Activity 1
Effect 1: Mario Kart Ink Debuff
- This is a full-screen post-processing effect applied to the entire camera 
- The shader involves applying temporary moving inkblot textures to the camera after the player gets attacked by a squid powerup
- I might activate the effect by enabling an entire post-processing effect and then using methods to instantiate inkblots at random coordinates. Once created, the inkblot shader graph will handle its shape and movement. 

Effect 2: Mario Kart Star Power Up Cart Effect
- This would effect an Objectfs Material
- This would be activated when players use a star power up
- I believe that this involves multiplying the rainbow effect on top of the model of the player and their cart kind of like the shiba activity but instead of replacing the model it combines them. The rainbow effect would likely be drawn from a pre-made gradient texture. 

### Activity 2
<img width="1022" height="563" alt="image" src="https://github.com/user-attachments/assets/a588276b-ec58-4319-bcd0-80e51300ae81" />
I've been working on a shadergraph which, when applied to an opaque sprite, distorts the sprite's portion of the screen by having the sprite act like a chameleon. It copies the colors of that screen portion but with UV values warped by the shader. I plan to use it to make bubble/droplet effects, but currently the material is only applied to the player's mouse cursor. 
The most significant problem was having the shader mimic what was already behind the sprite, since the easy solution of just linking a scene color node to base color is not supported by Unity 2D. Just figuring that out took a great deal of time, and afterwards I had to implement a convoluted workaround of using a camera layer instead, which involved creating an additional camera sorting layer and plenty of trial-and-error. Everything that could break, did. At one point I ended up accidentally creating the a 2D version of placing 2 vertically-aligned portals from Portal and jumping in, as the sprite would display a miniature version of the screen (which displayed a miniature version of itself displaying a miniature version of the screen displaying itself). 
