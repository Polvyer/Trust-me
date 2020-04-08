# cs426_Ocampo_William_Asgn6-11

Assignment 7

--AI and Mecanim--
1. Gina used AI/mecanim to create a cat character that walks around the first floor of the house and helps give the player a sense of home.
   Found a cat model with animations and implemented the slow walk animation. 
   Created a NavMesh for the house and made the cat a navigation agent.
   Added points on the mesh for pathfinding and added them to a list so the cat can walk to them in a random order. 
   Followed the NavMesh tutorial and used code from here: https://docs.unity3d.com/Manual/Navigation.html. 
2. Darrel
3. William


--Physics--
1. Hinge joints on all the doors of the house. This was mainly used to run the OpeningDoor script. Without it, we would have to rely on animations, which we might come back to if time permits.
2. Fog particle system was implemented in the front of the house. This system will be replicated once we add more to the level. The fog ties into the mysterious theme. The player throughout the level slowly remembers who they are, but initially doesn't. It's a mystery, and as such, a lot of components/effects that we will add/added tie into this theme.
3. Added torque to the character so the movement slows to a stop rather than going from moving to immediately stopped. This gave the character movement a more realistic feeling. I used this unity AddTorque tutorial as a reference https://learn.unity.com/tutorial/3d-physics?signup=true#5c7f8528edbc2a002053b513.

--Lights--
1. Directional light outside to immitate the sun/moon. 
2. Eight different dome lights in the house that light different rooms. 
3. Two different point lights.

--Sounds--
1. Cricket sound effect to help set the tone of the game. Game should be enigmatic and cricket sounds give off that mysterious vibe.
2. Open door sound effect that is triggered when the character walks through a door. This is a puzzle/exploration game. A lot of small details like an opening door sound are very useful in setting up the environment.
3. Stair sound effect occurs when player goes up/down stairs. This is the same as with the opening door sound.

--Textures--
1. Roof tiling
2. Wooden floor
3. Stone front porch
