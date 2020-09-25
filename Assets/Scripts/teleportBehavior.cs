using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public GameBehavior game;
    public GameObject destination;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = destination.transform.position;
        game.loselife(1);
    }
}
