using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidMasterControl : MonoBehaviour
{
    public PlayerBehav PB;
    public TentacleSwap TS;
    public TentacleGrabber TG1, TG2;

    public bool onOff;
    // Start is called before the first frame update
    void Start()
    {
        TG1 = TS.Tentacle1.GetComponent<TentacleGrabber>();
        TG2 = TS.Tentacle2.GetComponent<TentacleGrabber>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onOff == true)
        {
            PB.enabled = false;
            TS.enabled = false;
            TG1.enabled = false;
            TG2.enabled = false;
        } else
        {
            PB.enabled = true;
            TS.enabled = true;
            TG1.enabled = true;
            TG2.enabled = true;
        }
    }
}
