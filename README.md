# SurvivalShooter
A sample unity game where I am experimenting new features and other epic stuffs in my free time. Thanks unity for the game template !
The base game is a player shooting enemies which eventually will try to overwhelm the player. A score system is also there.

###### latest build downloadable at "_Playable_Build" folder

## New Functionalities 
- __Mini-map__

>a small minimap in corner to show the enemy presence in the map. Enemy is colour coded as red and the player as green. 

- __Added healthbar for enemies__

>Enemies will hame a small healthbar on top of them so that player can see how much health is remaining. Strategy is to help player determine the enemy health so that tthey can prioritise whom to shoot and run away as enemies tend to overwhelm the player.

- __Killed enemies drop point balls which can be collected by player__

>Once an enemy is killed, it will drop a point ball which can be collected by the player for extra points. Different enemies drop different coloured balls with varying points.

- __Health Bar fluctuation when under attack by player__

>When an enemy is under attack by the player , its health bar will flash. It helps player to know which enemy is getting hit when firing the gun.

- __Probability system in enemies droping point balls and point balls expiry__

>A system is implemented in which not all the enemies will drop the point balls. Its based on probability that a killed enemy has 50% chance to drop a point ball and other 50% chance to not drop a point ball.
Also a point ball has a specified time period after which it will disapper. So player has to collect it before it disapper to get the points

- __Pause and exit functionality__

>Implemented UI elements to pause the game and also to exit the game as player wishes.

- __Extra Sounds__

>Extra sounds are added , lastest being sound for collecting the point balls. 

## Upcoming Functionalities 

- __Health point balls__

>Killed enemies may drop a health point ball which restore the health of player 
