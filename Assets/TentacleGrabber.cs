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
    void Update()
    {
        if (on == true)
        {
            screenPos = Input.mousePosition;
            screenPos.z = 9.4f;

            worldPosition = cam.ScreenToWorldPoint(screenPos);

            Target.transform.position = worldPosition;

            Vector3 ForceDirection = transform.position - Target.transform.position;

            rb.AddForce(ForceDirection * -speed, ForceMode.Acceleration);

            if (Vector3.Distance(transform.position, mainBody.transform.position) > maxDist)
            {
                speed = speedHolder * -1;
            } else
            {
                speed = speedHolder;
            }

            if (Input.GetMouseButtonDown(0))
            {
                grabbing = !grabbing;
            }
        }

       
        if (grabbing == false)
        {
            grabbed = false;
            immovable = false;
            GrabHinge.connectedBody = carryObj.GetComponent<Rigidbody>();
        }

        if (immovable == true)
        {
            Vector3 BodDrag = transform.position - mainBody.transform.position;

            mainBodRb.AddForce(BodDrag * dragForce, ForceMode.Acceleration);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (grabbing == true && grabbed == false && other.GetComponent<Rigidbody>() != null && other.transform.tag != "Squid")
        {
            GrabHinge.connectedBody = other.GetComponent<Rigidbody>();
            grabbed = true;
            if (other.GetComponent<Rigidbody>().isKinematic == true)
            {
                immovable = true;
            }
        }
    }
}
