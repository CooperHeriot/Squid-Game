using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleGrabber : MonoBehaviour
{
    public bool on;

    //public float dist;
    public Camera cam;
    public float speed;
    private float speedHolder;
    public Vector3 screenPos, worldPosition;
    public GameObject Target;
    private Rigidbody rb;
    public GameObject mainBody;
    public float maxDist;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //dist = Vector3.Distance(transform.position, Target.transform.position);
        speedHolder = speed;

        maxDist = Vector3.Distance(transform.position, mainBody.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (on == true)
        {
            screenPos = Input.mousePosition;
            screenPos.z = 9.4f;

            worldPosition = cam.ScreenToWorldPoint(screenPos);

            Target.transform.position = worldPosition;

            Vector3 ForceDirection = transform.position - Target.transform.position;

            rb.AddForce(ForceDirection * -speed, ForceMode.Force);

            if (Vector3.Distance(transform.position, mainBody.transform.position) > maxDist)
            {
                speed = speedHolder * -1;
            } else
            {
                speed = speedHolder;
            }
        }

        
    }
}
