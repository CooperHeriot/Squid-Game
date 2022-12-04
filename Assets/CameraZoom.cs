using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public TentacleSwap swapControl;

    public GameObject SquidObj, CurrentArm;
    public GameObject Arm1, Arm2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (swapControl.swap == true)
        {
            CurrentArm = Arm1;
        } else
        {
            CurrentArm = Arm2;
        }

        transform.position = new Vector3((SquidObj.transform.position.x + CurrentArm.transform.position.x) / 2,
            (SquidObj.transform.position.y + CurrentArm.transform.position.y) / 2, (SquidObj.transform.position.z + CurrentArm.transform.position.z) / 2);
    }
}
