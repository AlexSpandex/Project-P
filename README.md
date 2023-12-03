# Shadows of the Mushroom Kingdom 🎮

Welcome to the Super Mario Unity Game! This game brings the classic Mario experience to life with added features and improvements. Below, you'll find details about the game's features and mechanics based on the commit messages.

## What's New? 🤔

#### Link to play game 👻: https://alexspandex.itch.io/project-p

## Instructions

- **Changed position of instructions**
  - The game provides on-screen instructions to guide players on how to play.

- **Hid Music Option in Main Menu for now**
  - The music option in the Main Menu is currently hidden, possibly for future updates or improvements.

## Win and Loss Conditions

- **Win Feedback Added 🆒**
  - A win condition has been implemented, and players receive feedback upon winning.

- **Added Loosing Feedback**
  - A loss condition has been implemented, and players receive feedback upon losing.

## Interesting Decision

- **Mario goes through pipe 🪈**
  - The game introduces pipes, hinting at potential level progression and hidden areas.

## Components

The game utilizes at least 12 components, including scripts and scriptable objects, ensuring a diverse and engaging experience.

## Saving and Loading

- **Loading System works even after quitting game 😎**
  - The game features a robust saving and loading system, allowing players to continue their progress even after quitting.

## Sound

- **Added instructions to Play Game on Screen**
  - The game includes sound elements, such as instructions, contributing to the overall player experience.

## Settings

- **Fixed Level to Level bug**
  - Settings adjustments, possibly related to level transitions, have been fixed.

## Main Menu and Gameplay

- **Added All Powerups**
  - The Main Menu showcases all powerups, indicating a variety of features players can expect during gameplay.

- **Fixed death bug**
  - A death animation bug has been fixed, enhancing the overall stability of the game.

- **Death animation works and koopa added**
  - The death animation works seamlessly, accompanied by the addition of a Koopa enemy for added challenge.

## Additional Features

- **Made Font more visible and added coins underground**
  - Visual enhancements have been made, making the font more visible, and coins have been placed underground for added exploration.

## Emergent Gameplay and Progression

- **Finally fixed death bug**
  - The fixed death bug contributes to a smoother and more enjoyable gameplay experience.

- **Magic Mushroom is now pops in 🍄**
  - The appearance of the magic mushroom adds an element of surprise and progression to the game.
 
- **Star Powerup is working now ⭐️**
  - The star powerup provides players with a unique ability, adding an interesting decision to the gameplay.

- **Mario Changes Colors with Star power ⭐️**
  - Visual feedback is provided as Mario changes colors when under the effect of the star powerup.

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
