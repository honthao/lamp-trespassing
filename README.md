# Lamp Trespassing

- Maya: outhred@cs.washington.edu
- Thao: uwthao07@cs.washington.edu
- Darius: dduciuc@cs.washington.edu
- Aaron: flaaroni@cs.washington.edu

### High Level Description
We built a 1st person POV stealth game, where the player has to navigate a maze without being seen by any enemy lamps. If the player comes too close to a lamp facing them, they’ll lose the game. If they’re able to sneak up on the lamp without being seen, they can disable it and add to their score. Once a player has found the key in the map and found the exit door, they’ll be able to complete the level. The objective is to complete the level while maximizing their score.

### Feature List
- A first person POV camera.
- Keyboard and mouse navigation for the player - WASD to move and panning with the mouse to change the viewpoint.
- Rotating enemy lamps dispersed throughout the level with field of view detection - if the player comes within a certain radius while the lamp is facing them, they’ll lose the game.
- A “lose” or “win” screen depending on the player’s outcome where the scene freezes and the player is offered the options to restart the game or go back to the main menu.
- The ability to disable enemy lamps by colliding with them.
- Score tracking throughout the game - your score increases by 1 every time you disable a lamp. Lamps do not respawn.
- A maze level made up of brick walls.
- A collectible key hidden in the maze needed for the win condition.
- An exit door to complete the level.
- A main menu to begin the game and to provide instructions on how to play the game.
- An original soundtrack and sound effects
- X-ray vision that allows the player to see the lighting of the lamps behind walls.

### Assets/Models from Unity Asset Store:
- Lamps
- Bricks (i.e. wall textures)
- Key
- Trees
- Wooden stacks
- Barrels/Canisters
- Torches

### Team Assignments
- Maya: Enemy design & animation, cone-of-vision detection
- Thao: Player design & navigation, score & key tracking, UI components/menus, lose/win & restart game mechanics
- Darius: Debugging, programming, asset finding, level design
- Aaron: X-ray vision lighting, level design, sound design, rotation animation
