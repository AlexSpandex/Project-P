# Shadows of the Mushroom Kingdom 🎮

This document includes Scripts/Components, GameObjects, Scenes 📝

### Scripts/Components 🧩

1. **PlayerController 🕹️**

   - *Description*: This script handles the movement and control of the player character.
   - *Functionality*: It handles player input, horizontal movement, jumping, and collision detection.

2. **SceneTransition 🚀**

   - *Description*: This script manages scene transitions when the player interacts with designated triggers.
   - *Functionality*: It loads specified scenes when triggered, facilitating the movement between game levels.

3. **Extensions 🛠️**

   - *Description*: A utility class that defines an extension method for Rigidbody2D to perform raycasting.
   - *Functionality*: This script provides an efficient way to perform raycasting with Rigidbody2D objects.

4. **SpriteRenderer 🖼️**

   - *Description*: Unity's built-in component for rendering 2D sprites.
   - *Functionality*: It renders the visual representation of game objects with sprites.

5. **OnCollision2D 💥**

   - *Description*: A Unity event triggered when two Collider2D components (e.g., player and obstacles) collide.
   - *Functionality*: It allows you to define custom behavior when collisions occur, such as player taking damage, collecting items, or triggering events.

### GameObject Composition 🎮

#### Mario (Player) 🧍

- *Components*:
  - Rigidbody2D: Physics behavior of the player character.
  - Collider2D: Collision detection for the player character.
  - Animator: Manages player character animations.
  - PlayerController: Custom script for player character control.

#### Castle (Door) 🏰

- *Components*:
  - Collider2D: Trigger collider for detecting player interaction.
  - SceneTransition: Custom script for handling scene transitions.

#### Brick (Block) 🧱

- *Components*:
  - BoxCollider2D: Defines the physical boundaries of the brick block.
  - SpriteRenderer: Renders the block's appearance with a brick texture.
  
  - *Functionality*:
    - The BoxCollider2D ensures that the brick block has a physical presence and can be interacted with.
    - The SpriteRenderer provides a visual representation, making the block appear as a brick in the game.

...

### Acknowledgments 🙌

I would like to extend my sincere gratitude to [Zigurous](https://www.youtube.com/watch?v=GCkq6XqyJZg&list=PLqlFiJjSZ2x1mrMpSQgYdRm8PyWRTg6He&index=1&ab_channel=Zigurous) for their excellent YouTube tutorial
