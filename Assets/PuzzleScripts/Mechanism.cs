using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanism : MonoBehaviour
{
    public GameObject Tip, point;
    public float radius;
    public Door dor;

    public float dist;

    public Rigidbody rb;
    public bool lok;

    //public bool Lever;
   // public float Max, Min;
    //public GameObject handle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(Tip.transform.position, point.transform.position);

        if (dist < radius)
        {
            dor.activated = true;
            if (lok == true)
                {
                rb.isKinematic = true;

                }
        } else
        {
            dor.activated = false;
        }
    }
}
