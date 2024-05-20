# Lamp Trespassing

- Maya: outhred@cs.washington.edu
- Thao: uwthao07@cs.washington.edu
- Darius: dduciuc@cs.washington.edu
- Aaron: flaaroni@cs.washington.edu

### High level description
A first-person stealth game in a maze setting. The maze will have rooms, hallways, and doors for the player to explore. The player must navigate from their entry point to an exit without being seen by any enemies. Enemies have a fixed position, but a rotating cone of vision. If a player is within any enemy’s cone of vision and there are no walls between them, then the player is “seen” and they lose. If the player can get close to an enemy without being seen, they can deactivate/cause the enemy to disappear to make it easier to continue on their path. The user will move the player/deactivate enemies using keyboard navigation.

### Feature list
- A player that can move around the setting, with the objective of getting from point A to point B
- A maze-like setting with walls and rooms, with an entry and exit point
- Enemies with rotating point of view for the player to avoid. Enemies disappear if the player can touch them without being seen
- Keyboard navigation (WASD) for the player
- 1st person POV camera following the player’s movements
- Special lighting where lights aren’t blocked by walls/objects except enemy material. Allows player to view enemies even if there's a wall between them (if we have time)

### Team assignments
- Maya: Enemy design & animation, cone-of-vision detection
- Thao: Player design & animation, keyboard navigation
- Darius: Lighting, level design, win/lose mechanics
- Aaron: Lighting, level design, sound design

### Development plan
- Design the maze setting, enemies, and the player characters.
- Player animation and navigation with the keyboard.
- Player & enemy interaction (enemy disappears when touch)
- Enemy animation and rotating cone of vision.
- Detecting player exit/win condition - getting to a point in the maze without being seen.. 
- Detecting the lose condition - when a player is seen by an enemy.
- Stretch goal: Implementing special lighting - where light isn’t blocked by walls and objects (except for enemies).

### Checkpoint
- Have a basic maze setting and character designs.
- Complete player movement
- Finish player and enemy interaction

### Materials and any external help needed 
- We may or may not require some assets from the unity asset store - depending on the final design of the level, players, and enemies.

### Key Risks and Mitigations
- If the lose condition is too difficult to implement, we can switch to a simpler condition just based on whether the player is within a certain radius to the enemy.
Reduce the size of the map, and less enemies
