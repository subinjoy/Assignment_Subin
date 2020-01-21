# Assignment_Subin
Snake game Source Files


.....CODE DESIGN
TWO SCENES ARE PRESENT
 1.MAIN MENU
 2.GAMEPLAYSCENE
 
............GAMEPLAY SCENE...
      1.snakeClass Script    : Contains snake creation,movement,newspawning and all properties.
                               size of the snake and speed can be changed easily through Inspector.
                                Snake textures are downloaded from assetStore and are present inside "Snakes" Folder.

      2.GameController Script: Contains All the function executions with all initialisations and updations and has access to other scripts.
      3.LoadData Script      : This script is used to read food colours from json file.
                               json file is located inside Resources folder.
      4.CollisionClass        :This class is used to implement all collision related functions .
      5.UIClass               : all functions related to scene management.
      6.ScoreManager and FoodClass are used for managing score and food related functions.
      7.Two types of food are loaded:Red and Blue.
        Red: Gives 15 points 
        Blue: Gives 20 points
        Points are calculated as per the requirement.
          
 GAMEPLAY VIDEO LINK: https://drive.google.com/file/d/1WqedW7zOBpaLvIINhMSf0Nu5fFlHZ2eD/view?usp=sharing
  
...........END...........
