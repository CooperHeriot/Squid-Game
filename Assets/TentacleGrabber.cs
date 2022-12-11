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
    private Rigidbody mainBodRb;
    public float maxDist;
    public float dragForce;

    //grab stuff
    public GameObject carryObj;
    public HingeJoint GrabHinge;
    public Rigidbody GrabbedObj;
    public bool grabbing;
    public bool grabbed;
    public bool immovable;
    public bool seen;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //dist = Vector3.Distance(transform.position, Target.transform.position);
        speedHolder = speed;

        maxDist = Vector3.Distance(transform.position, mainBody.transform.position);

        mainBodRb = mainBody.GetComponent<Rigidbody>();

        //GrabHinge = GetComponent<HingeJoint>();
        GrabHinge.connectedBody = carryObj.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (on == true)
        {
            screenPos = Input.mousePosition;
            screenPos.z = 9.4f;

            worldPosition = cam.ScreenToWorldPoint(screenPos);

            Target.transform.position = worldPosition;

            Vector3 ForceDirection = transform.position - Target.transform.position;

            if (GetComponent<Renderer>().isVisible)
            {
                rb.AddForce(ForceDirection * -speed, ForceMode.Acceleration);
            }         

            if (Vector3.Distance(transform.position, mainBody.transform.position) > maxDist)
            {
                speed = speedHolder * -1;
            } else
            {
                speed = speedHolder;
            }           
        }

        if (immovable == true)
        {
            Vector3 BodDrag = transform.position - mainBody.transform.position;

            mainBodRb.AddForce(BodDrag * dragForce, ForceMode.Acceleration);
        }
    }

    void Update()
    {
        if (on == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                grabbing = !grabbing;
            }

            if (grabbing == false)
            {
                grabbed = false;
                immovable = false;
                GrabHinge.connectedBody = carryObj.GetComponent<Rigidbody>();
            }
        }        
    }


    void OnTriggerEnter(Collider other)
    {
        if (grabbing == true && grabbed == false && other.GetComponent<Rigidbody>() != null && other.transform.tag != "Squid" && other.transform.tag != "MainSquid")
        {
            GrabHinge.connectedBody = other.GetComponent<Rigidbody>();
            grabbed = true;
            if (other.GetComponent<Rigidbody>().isKinematic == true)
            {
                immovable = true;
            }
        }
    }

    private void OnBecameVisible()
    {
        seen = true;
    }
    private void OnBecameInvisible()
    {
        seen = false;
    }
}
