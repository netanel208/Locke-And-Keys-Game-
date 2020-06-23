# Locke & Key Game

Final project in development of computer games course.

Created by:

[Odelia Hochman](https://github.com/OdeliaHochman)

[Netanel Davidov](https://github.com/netanel208)

itch.io: [Locke & keys](https://odeliamos0.itch.io/locke-key)

## Background
The game is based on the series, comics and books "Locke & Key" .

During the game, the player moves around the house and outside.
His goals:
- Find magical keys by whispering sounds.
- Fighting demons and human enemies who try to hurt the player and do so with various objects and magical keys.
- Eliminate the Hell's Demon that is trying to take over the world with the help of the magical keys

### Short explanation to the player:

Welcome to the Locke family. 

Tour the house and find magical and mysterious keys that give their owners mystical abilities and that opens doors to intriguing and surprising worlds. 

You must understand alone the key capabilities and use them in appropriate situations.

During your stay, you will encounter human enemies and scary demons - that wake up from a long-standing coma that try to hurt you,
snatch away the magical keys and bring you to Hell's Demon. 

During the game, you will be joined by additional characters - family members who will help you fight enemies, keep the magical keys, and complete tasks.
During the game, you must acquire skills that will help you understand how to fight and eliminate Hell's Demon before she will take over the world.


### First 30 seconds
The player has a Menu --> he clicks on -  New Game button.

The player sees a short animation of entering the KeyHouse.
The player enters the KeyHouse.

A tutorial appears to him as to show him what he should do.
He must look for the first magical key by the sound of whispers.
When he finds the key, the corresponding key card show on the screen  and shows him the name of the key and what it is opened. 
Then the player will have to understand that he has to open the mirror in the closet with the help of the mirror key he found.
Then, his mom who was in the same room will come into the mirror, and the mirror would break.
A message will appear to the player that the mirror was broken, his mother stuck there and must be rescued by finding a new mirror.
The player looks for a new mirror and opens it.

Here begins the first mission. 
The player enters a mirror room where there is a maze. 
He must find his mother in the maze and get out of the room as soon as possible.

 
 
 
 
### Player move:
The player has an option to move forward, backward, right, left. The moving is done using the arrow keys and doing so activates the animation that matches the movement.

- `up key` - moves the player forward.
- `down key` - moves the player backward.
- `right key` - moves the player right.
- `left key` - moves the player left.

Picking  objects will be done by  mouse clicking.


## Scripts
### Player:
- [Mover](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Player/Mover.cs) - Moving the player
- [HealthBarPlayer](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Player/HealthBarPlayer.cs) - Represents the Health of the player  in the game
- [PickingKey](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Player/PickingKey.cs) - This behavior is make the player pick up key from the floor
- [PlayerKeys](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Player/PlayerKeys.cs) - The collection of keys the player has already encountered

### Keys:
- [KeyProperties](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/keys/KeyProperties.cs) - This class contains all key properties as: holes it open, audio source, current hole that opened. 
- [PickingUp](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/keys/PickingUp.cs) - This class allows the key behavior to be in the player's hand when the player clicks it with the mouse. 

### Holes:
- [HoleActions](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Holes/HoleActions.cs) - This class allow specify which key the hole belongs to and which key animation will be triggered when you click the hole with the mouse.

### Key Cards:
- [Card](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/KeyCards/Card.cs) - Create a Card object.
- [CardDisplay](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/KeyCards/CardDisplay.cs) - Display the card on the screen with all its details and close

### Levels:
- [OpenGame](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Levels/OpenGame.cs) - Represents the first scene in the game(just show the house from outside).
- [Level1](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Levels/Level1.cs) - Represents the first scene(level) at KeyHouse, the level1 contains some states that the player may be during the level.


### Menu: (asset)
- [MenuController](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/MenuScripts/MenuController.cs)
- [init_LoadPreferences](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/MenuScripts/Init_LoadPreferences.cs)

### Mirror:
- [BreakMirror](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Mirrors/BreakMirror.cs) - This behavior causes the mirror to break and leave fragments on the floor.


### Health Bar:
- [HealthBar](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/HealthBar.cs)


### Dialogue:
- [Dialogue](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Dialogue/Dialogue.cs
) - Represents the content of the dialog that will display
- [DialogueManager](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Dialogue/DialogueManager.cs
) - Responsible for opening and closing the dialogue and displaying the details on the screen
- [DialogueTrigger](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/Dialogue/DialogueTrigger.cs
) - Responsible for starting the dialogue


### Button:
- [DisableButton](https://github.com/OdeliaHochman/gamedev-Locke-and-Key-Game/blob/master/scripts/DisableButton.cs) - Deletes the button when pressed.


## Animation:

### Scene “1” : 

Camera

### Scene “2” :

Key

Mother - enter to the mirror after the player find the Mirror-key.

Mirror

Player

Dialogue


## Audio:
whispering sounds for magical keys:
We created Audio source for a key object and configured it as follows: Being played in loops, played in a three-dimensional area.
we have defined that as the player moves away from the area, the sound becomes louder and as the noise approaches exponentially.


## Images
#### Menu
![image](https://user-images.githubusercontent.com/45036697/85391050-5a96cf00-b552-11ea-8032-1d2fccf4a4aa.png)



#### Scene1

![image](https://user-images.githubusercontent.com/45036697/85391403-cb3deb80-b552-11ea-83eb-ba59899f5aa7.png)


#### Scene2

![image](https://user-images.githubusercontent.com/45036697/85391553-ffb1a780-b552-11ea-9796-06fb4156a980.png)


#### Mirror Room

![image](https://user-images.githubusercontent.com/45036697/85391259-99c52000-b552-11ea-85b9-3cdaad74ca41.png)


#### Cemetery

![image](https://user-images.githubusercontent.com/45036697/85391294-a5b0e200-b552-11ea-9a3b-fbf57a74a13e.png)



