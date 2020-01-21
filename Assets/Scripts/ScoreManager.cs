using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public string currentFood, PreviousFood;
    public FoodClass FoodClass_Access;
    public LoadData dataAccess;
    public int PlayerScore = 0;
   public int scoreValue;
    public TMP_Text scoreText, FinalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerScore);
    }
    public void InitScore()
    {
        scoreText.text = PlayerScore.ToString();
        if (FoodClass_Access.currentFood == FoodClass_Access.food1)
        {
            scoreValue = 15;
            
        }
        if (FoodClass_Access.currentFood == FoodClass_Access.food2)
        {
            scoreValue = 20;
        }
    }
    public void UpdateScore()
    {
        scoreText.text = PlayerScore.ToString();
        FinalScore.text = PlayerScore.ToString();
        if (currentFood == PreviousFood)
        {
            if (currentFood == dataAccess.foodTypes[0])
            {
                scoreValue = 15;
            }
            else if (currentFood == dataAccess.foodTypes[1])
            {
                scoreValue = 20;
            }
        }
        else if (currentFood != PreviousFood)
        {
            if (currentFood == dataAccess.foodTypes[0])
            {
                scoreValue = (-PlayerScore + 15);
            }
            else if (currentFood == dataAccess.foodTypes[1])
            {
                scoreValue = (-PlayerScore + 20);
            }
        }
        
    }
}
