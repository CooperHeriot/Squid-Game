using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 50;

    public bool inWater;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (inWater == false)
        {
            rb.AddForce(0, 0, force, ForceMode.Force);
        }        
    }
}
