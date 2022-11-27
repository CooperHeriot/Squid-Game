using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool activated;
    public GameObject startPoint, endPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activated == true)
        {
            transform.position = Vector3.Slerp(transform.position, endPoint.transform.position, speed * Time.deltaTime);
        } else
        {
            transform.position = Vector3.Slerp(transform.position, startPoint.transform.position, speed * Time.deltaTime);
        }
    }

    public void toggleActivate()
    {
        activated = !activated;
    }
}
