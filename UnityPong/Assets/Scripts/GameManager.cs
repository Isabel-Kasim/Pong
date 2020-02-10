using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;

    [SerializeField] private ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        ball.Restart();
    }

    public void Score(Goal goal)
    {
        scoreKeeper.AddScore(goal);
        ball.Restart();
    }
    
    public void restartGame()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("Pong");
        }
    }


}
