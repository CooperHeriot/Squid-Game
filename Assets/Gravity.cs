using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 50;
    public float Dampner = 1;

    public bool inWater;

    private GravityManger GM;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GM = GameObject.FindObjectOfType<GravityManger>().GetComponent<GravityManger>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (inWater == false)
        {
            rb.AddForce(0, 0, (force / Dampner), ForceMode.Force);
        }        
    }

    public void updateGrav()
    {

    }
}
