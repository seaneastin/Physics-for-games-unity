using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorebehavior : MonoBehaviour
{
    public GameBehavior game;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        game.addpoints(100);
        game.bounces++;

        if (game.bounces >= 3)
        {
            game.bounces -= 3;
            game.multiplier++;
        }

    }


}
