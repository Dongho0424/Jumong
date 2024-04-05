# Jumong
This repository shows a bow game demo developed with Unity as part of a team project for VR/AR introduction and practice class.  
It utilizes free models and animations from [Sketchfab](https://sketchfab.com/) and [Mixamo](https://www.mixamo.com/), and the background music was created using free music provided.  
It was tested with **Oculus Quest 2**.  

<table align="center" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td><img src="https://github.com/Dongho0424/Jumong/assets/102637331/919655aa-f7eb-432c-9417-b7886ba59c4e" width="400"/></td>
    <td><img src="https://github.com/Dongho0424/Jumong/assets/102637331/ec24e4c8-db68-40c8-a470-48cee5668473" width="400"/></td>
  </tr>
</table>

## Bow
- Fixed the part where the bowstring is held to the local z-axis, allowing the arrow to be drawn along one axis.
- Implemented natural movement by rotating the bow's body based on the vector between the bowstring's grip and the bow's body.
- Normalized the extent to which the bowstring is pulled to transmit to the arrow's rigidbody force, making the arrow go further the harder it is pulled.
## Arrow
- Prevented the arrow from interacting with other monsters once it triggers upon contact with a monster.
- Changed the arrow to kinematic the moment it touches the ground to simulate the effect of being stuck in the ground.
## Monster
- Upon being hit by an arrow while either attacking or running, the monster transitions into a death state, triggering appropriate animations.
- Optimized by removing the collider upon death to prevent further arrow hits and destroying the monster after 6 seconds.
## Hand
- Implemented natural hand movements by importing hand prefabs and animations.
- Fixed the left hand to always hold the bow by automatically grabbing the bow at game start, locking the grab animation, and removing interaction from the left controller.
## NavMesh & Spawn
- Spawns at random positions within a designated area at specific times, based on a certain region. Receives an array of prefabs from the Inspector, using a specific index's prefab. Spawns by instantiating the chosen - - prefab at random positions determined by specified Box Colliders in the Inspector. Runs towards the target destination (castle) as directed by the NavMeshAgent's SetDestination. Bakes the terrain NavMesh area.
## Difficulty Settings
- Adjusts the number and types of spawn entities in the SpawnGenerator Script based on the difficulty level entered in the Intro Scene. Sets different health levels for bosses and giants in Medium and Hard difficulties.
## Background Music & Sound Effects Implementation
- Utilizes the Singleton pattern for global access. Prevents destruction on scene transition, attaching the Script to the Intro Scene to maintain background music across scene transitions.
- Implements volume control for fade-out effects to reduce user discomfort from sudden sounds.
- Selects a few appropriate sounds for enemies, analyzing enemy animations to play attack sounds randomly in sync with
