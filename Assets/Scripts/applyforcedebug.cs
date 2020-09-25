using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class applyforcedebug : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 force;
    public bool applyforce;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (applyforce)
        {
            rb.AddForce(force);
            applyforce = false;
        }
    }
}
