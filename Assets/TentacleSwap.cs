using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleSwap : MonoBehaviour
{
    public bool swap;
    public GameObject Tentacle1, Tentacle2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (swap == true)
        {
            Tentacle1.GetComponent<TentacleGrabber>().on = true;
            Tentacle2.GetComponent<TentacleGrabber>().on = false;
        } else
        {
            Tentacle1.GetComponent<TentacleGrabber>().on = false;
            Tentacle2.GetComponent<TentacleGrabber>().on = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            Swithc();
        }
    }

    public void Swithc()
    {
        swap = !swap;
    }
}
