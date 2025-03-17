# Chicken-Hunter-In-Forest
Unity Version: 2022.3.26f1

![alt text](Screenshots/ss1.png)
## Gameplay
The player can use the WASD to control the chicken’s movement, and use SPACE to jump. Moreover, the player has to use MOUSE to rotate the view and CLICK to shoot the lions.

![alt text](Screenshots/ss2.png)

## Game Mechanism
The game will end whenever the player presses the esc button. Other than that, when the player successfully defeats all enemies in the game, a RESTART button will appear. And the player can restart the game by clicking the button.

<p>
  <img src="Screenshots/ss3.png" width="48%" />
  <img src="Screenshots/ss4.png" width="48.5%" />
</p>

## InputSystem Settings and Scripts
<b>Input Actions:</b>
define the player movement, jumping, and shooting actions.

![alt text](Screenshots/ss5.png)

<b>InputManager.cs: </b>
set input actions and classes and update player position and view direction according to the inputs.

<p>
  <img src="Screenshots/ss6.png" width="44%" />
  <img src="Screenshots/ss7.png" width="54%" />
</p>

<b>PlayerMotor.cs:</b>
handle logics for moving and jumping.

<p>
  <img src="Screenshots/ss8.png" width="32%" />
  <img src="Screenshots/ss9.png" width="66%" />
</p>

<b>PlayerLook.cs:</b>
handle logics for calculating the looking direction.

<p>
  <img src="Screenshots/ss10.png" width="30%" />
  <img src="Screenshots/ss11.png" width="69%" />
</p>

## Prefab Settings
I created prefabs for constructing the forest maze. There are two rows and 3 columns of objects.

![alt text](Screenshots/ss12.png)

The aerial view of the forest maze.
![alt text](Screenshots/ss13.png)

## Enemy (Lion) Information
There are a label and a bloodbox which displays the HP above each enemy. That information will always be facing the player.

![alt text](Screenshots/ss14.png)

## Shooting
I use two particle systems to implement the shooting effect, one is put in front of the croissant while the other is displayed at the hit surface.

<p>
  <img src="Screenshots/ss15.png" width="55%" />
  <img src="Screenshots/ss16.png" width="43%" />
</p>

To implement the latter one, I utilize the “Instantiate()” to create the effect and set it to destroy after 2 seconds to prevent from generating too many objects.

![alt text](Screenshots/ss17.png)

## Asset Store Packages
1. Low-Poly Simple Nature Pack - JustCreate
![alt text](Screenshots/ss18.png)
2. 5 animated Voxel animals - VoxelGuy
![alt text](Screenshots/ss19.png)
3. FREE Casual Food Pack- Mobile/VR - Lumo-Art 3D
![alt text](Screenshots/ss20.png)
4. Particle Pack - Unity Technologies
![alt text](Screenshots/ss21.png)