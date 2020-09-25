using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcherBehavior : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            //get ther ray from the camera to the mouse
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
            //get the ray from the camera to the mouse
            Plane playerPlane = new Plane(Vector3.up, transform.position);
            //find where the ray intersects the plane
            float rayDistance = 0.0f;
            playerPlane.Raycast(mouseRay, out rayDistance);


            RaycastHit hitObject;

            if (Physics.Raycast(mouseRay, out hitObject))
            {
                if (hitObject.collider.gameObject.CompareTag("Launcher"))
                rb.AddForce(5000, 0, 0);
            }
        }
    }
}
