using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private Text leftTextScore;
    [SerializeField] private Text rightTextScore;
    

    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;

    [SerializeField] private GameManager gameManager;


    private int leftScore = 0;

    private int rightScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        RefreshScore();
    }

    private void RefreshScore()
    {
        //some function to update the Text string
        leftTextScore.text = leftScore.ToString();
        rightTextScore.text = rightScore.ToString();
    }
    public void AddScore(Goal scoringSide)
    {
        if (scoringSide == leftGoal)
        {
            rightScore += 1;
        }

        else if (scoringSide == rightGoal)
        {
            leftScore += 1;
        }
        if (leftScore >= 11)
        {
            leftTextScore.text = "You're Winner!";
            rightTextScore.text = "Loser";
            gameManager.restartGame();
           
            
        }
        else if (rightScore >= 11)
        {
            rightTextScore.text = "You're Winner!";
            leftTextScore.text = "Loser";
            gameManager.restartGame();
            
            
        }
        else
        {
            RefreshScore();
        }
    }
}
