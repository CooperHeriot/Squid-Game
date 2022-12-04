using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Current : MonoBehaviour
{
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>() != null && other.transform.tag == ("MainSquid"))
        {
            Rigidbody temprb = other.GetComponent<Rigidbody>();

            temprb.AddForce(transform.forward * power);
        }
    }
}
