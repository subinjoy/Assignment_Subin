using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionClass : MonoBehaviour
{
    public SnakeClass SnakeClass_Access;
    public FoodClass FoodClass_Access;
    public GameController gamecontrol_Access;
    public ScoreManager ScoreManager_Access;
    float Timer;
   
  
    // Start is called before the first frame update
    void Start()
    {
      
        SnakeClass_Access = FindObjectOfType<SnakeClass>() as SnakeClass;
        FoodClass_Access = FindObjectOfType<FoodClass>() as FoodClass;
        gamecontrol_Access = FindObjectOfType<GameController>() as GameController;
        ScoreManager_Access = FindObjectOfType<ScoreManager>() as ScoreManager;
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == "FOOD")
        {
            
            if (collision.gameObject.name == "snakeBody")
            {
                ScoreManager_Access.PlayerScore += ScoreManager_Access.scoreValue;
                SnakeClass_Access.CreateSnakeGrid();
                ScoreManager_Access.PreviousFood = FoodClass_Access.currentFoodType;
                FoodClass_Access.SpawnFood();
                ScoreManager_Access.currentFood = FoodClass_Access.currentFoodType;
                Destroy(gameObject);
            }
                
        }
        if (this.gameObject.tag == "Edge")
        {
            if (collision.gameObject.name == "snakeBody")
            {
                gamecontrol_Access.gameOver = true;
               
            }
        }
        if (this.gameObject.tag == "SNAKE")
        {
            if (Timer > 1)
            {
                if (collision.gameObject.name == "snakeBody")
                {
                    
                     gamecontrol_Access.gameOver = true;
                       
                }
            }
        }
       
    }
   
}
