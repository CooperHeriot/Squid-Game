using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanism : MonoBehaviour
{
    public GameObject Tip, point;
    public float radius;
    public Door dor;

    public float dist;
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
        } else
        {
            dor.activated = false;
        }
    }
}
