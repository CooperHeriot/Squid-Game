using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleGrabber : MonoBehaviour
{
    public bool on;

    //public float dist;
    public Camera cam;
    public float speed;
    public Vector3 screenPos, worldPosition;
    public GameObject Target;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //dist = Vector3.Distance(transform.position, Target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        RaycastHit hit;

        Ray beam;

        beam = cam.ScreenPointToRay(Input.mousePosition);
        */
        if (on == true)
        {
            /*
            screenPos = Input.mousePosition;
            screenPos.z = dist;

            worldPos = cam.ScreenToWorldPoint(screenPos);

            dragObj.transform.position = worldPos;
            

            targetPosition = Input.mousePosition;
            targetPosition.z = 0;
            
            worldPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 5;

            Target.transform.position = worldPosition;

            Vector3 ForceDirection = transform.position - Target.transform.position;

            rb.AddForce(ForceDirection * -speed);
            */
            screenPos = Input.mousePosition;
            screenPos.z = 9.4f;

            worldPosition = cam.ScreenToWorldPoint(screenPos);

            Target.transform.position = worldPosition;

            Vector3 ForceDirection = transform.position - Target.transform.position;

            rb.AddForce(ForceDirection * -speed, ForceMode.Force);
        }

        
    }
}
