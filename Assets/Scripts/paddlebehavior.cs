using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlebehavior : MonoBehaviour
{
    public string key;
    public Rigidbody rb;
    public HingeJoint Joint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(key))
        {
            Joint.useMotor = false;
        }
        if (Input.GetKeyDown(key))
        {
            Joint.useMotor = true;
        }
    }
}
