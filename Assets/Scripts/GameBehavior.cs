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
    public UIBehavior UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (scoretogetlife >= 5000)
        //{
        //    scoretogetlife -= 5000;
        //    Lives++;
        //}
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

    void resetScore()
    {
        Score = 0;
    }    

    void gameover()
    {

        ball.SetActive(false);
        UI.restartgame.gameObject.SetActive(true);
    }

    public void gamestart()
    {
        resetmultiplyer();
        resetScore();
        Lives = 3;
        ball.SetActive(true);
    }

    public void loselife(int lives)
    {

        Lives -= lives;
        if (Lives <= 0)
        {
            gameover();
        }

    }

}
