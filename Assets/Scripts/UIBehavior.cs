using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    public GameBehavior game;
    public Text pointtext;
    public Text livestext;
    public Text multiplier;
    public Button restartgame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointtext.text = "Points: " + game.Score;
        livestext.text = "Lives: " + game.Lives;
        multiplier.text = "Multiplier: " + game.multiplier;
    }
}
