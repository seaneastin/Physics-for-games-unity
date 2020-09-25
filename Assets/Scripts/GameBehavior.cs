using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public int Lives;
    public int Score;
    public int multiplier;
    public int bounces;
    public int scoretogetlife;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Lives <= 0)
            {
                gameover();
            }

        //if (scoretogetlife >= 5000)
        //{
        //    scoretogetlife -= 5000;
        //    Lives++;
        //}

        if (bounces >= 3)
        {
            bounces -= 3;
            multiplier++;
        }
    }
    public void addpoints(int points)
    {
        Score += points * multiplier;
        scoretogetlife += Score;
    }

    public void addmultiplyer()
    {
        multiplier++;
    }

    void resetmultiplyer()
    {
        multiplier = 1;
    }

    void gameover()
    {
        resetmultiplyer();
        ball.SetActive(false);
    }

    void gamestart()
    {
        Lives = 3;
        ball.SetActive(true);
    }

    public void loselife(int lives)
    {
        Lives -= lives;
    }

}
