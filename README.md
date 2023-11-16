# Shadows of the Mushroom Kingdom 🎮

## What's New? 🤔

#### Link to play game 👻: https://alexspandex.itch.io/project-p

#### Saving and Loading 📝
   - Player could pause Game to Save anywhere in 1 scene and will be loaded in the exact spot they saved at from the Pause Menu
#### Sound 🔊
   - Mario Music plays as you move through the first and second level
#### Settings ⚙️
   - In the Main Menu, there's an options page that's empty, but has a back button
   - In the Pause Menu, there's a volume page (settings techinally) to adjust the volume of the music
#### Main Menu, Gameplay Scene(s), Pausing, Scene Transitions 🎩 
   - Main menu is the first scene loaded into
   - Gameplay Scenes are Level 1-1 and Level 1-2
   - Pause Scene is included in Scenes Level 1-1 and Level 1-2 through Canvas
   - Scene Transition happens currently only in Main Menu to Level 1-1 and techinally Level 1-2, but need to glitch to get there
#### A more complicated scope of gameplay features than Assignment 1
   - Mario is able to jump on Goombas and flatten them
   - Mario could get activated in a death scene now when interacting with Goombas
#### Some form of emergent gameplay or progression is provided
   - Goombas are in the game walking and could kill mario if interacted with from side to side
   - Level 1-1 could lead to Level 1-2 if player could get passed over Flag Pole somehow

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
    - The BoxCollider2D ensures that the brick block has a physical presence and can be interacted with.
    - The SpriteRenderer provides a visual representation, making the block appear as a brick in the game.

#### Hard Block

- *Components*:
  - BoxCollider2D: Defines the physical boundaries of the hard block.
  - SpriteRenderer: Renders the block's appearance with a hard block texture.

  - *Functionality*:
    - The BoxCollider2D ensures that the hard block has a physical presence and can be interacted with.
    - The SpriteRenderer provides a visual representation, making the block appear as a hard block in the game.

### Cloud 

- *Components*:
  - SpriteRenderer: Renders the block's appearance with a cloud texture.

### Mystery Block

- *Components*:
  - SpriteRenderer: Renders the block's appearance with a mystery texture.
  - BoxCollider2D: Defines the physical boundaries of the mystery block.

 ### Mario-Style Pipe

- *Components*:
  - SpriteRenderer: Renders the pipe's appearance with a green pipe texture.
  - BoxCollider2D: Defines the physical boundaries of the mario pipe.

### Mario-Style Flag

- *Components*:
  - SpriteRenderer: Renders the pipe's appearance with a flag texture.
  - BoxCollider2D: Defines the physical boundaries of the mario flag.

### Bush 

- *Components*:
- SpriteRenderer: Renders the block's appearance with a bush texture.

### Bush 

- *Components*:
  - SpriteRenderer: Renders the block's appearance with a bush texture.

### Hill 

- *Components*:
  - SpriteRenderer: Renders the block's appearance with a hill texture.

### Scenes

1. **Level1-1Scene**

   - *Description*: The first level of the game.
   - *GameObjects*:
     - Player: The player character controlled by the player.
     - Pipes: Obstacles to jump over
     - TransitionTrigger: Trigger for transitioning to the next level.

2. **Level1-2Scene**

   - *Description*: The second level of the game.
   - *GameObjects*:
     - Player: The player character controlled by the player.

### Acknowledgments 🙌

I would like to extend my sincere gratitude to [Zigurous](https://www.youtube.com/watch?v=GCkq6XqyJZg&list=PLqlFiJjSZ2x1mrMpSQgYdRm8PyWRTg6He&index=1&ab_channel=Zigurous) for their excellent YouTube tutorial
