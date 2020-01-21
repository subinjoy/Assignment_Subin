using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool gameOver;
    public SnakeClass snakeClass_Access;
    public FoodClass FoodClass_Access;
    public ScoreManager ScoreManager_Access;
    public GameObject GameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        snakeClass_Access.InitilaliseSnake();
        FoodClass_Access.SpawnFood();
        ScoreManager_Access.InitScore();
    }
    // Update is called once per frame
    void Update()
    {
        snakeClass_Access.KeyBoardControl();
        if(!gameOver)
        snakeClass_Access.MoveSnake();
        ScoreManager_Access.UpdateScore();
        if (gameOver)
            GameOverPanel.SetActive(true);
       
    }
}
