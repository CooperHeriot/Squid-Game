using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrabUI : MonoBehaviour
{
    public TentacleSwap TS;
    public TentacleGrabber TG1, TG2;

    public TextMeshProUGUI T1, T2, T11, T22;
    // Start is called before the first frame update
    void Start()
    {
        TG1 = TS.Tentacle1.GetComponent<TentacleGrabber>();
        TG2 = TS.Tentacle2.GetComponent<TentacleGrabber>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TS.swap == true)
        {
            T11.text = (" ");
            T22.text = ("Active");
        }else
        {
            T11.text = ("Active");
            T22.text = ("");
        }


        if (TG1.grabbing == false)
        {
            T1.text = ("Idle");
        } else
        {
            if (TG1.grabbed == true)
            {
                T1.text = ("Grabbed");
            } else
            {
                T1.text = ("Grabbing...");
            }
        }

        if (TG2.grabbing == false)
        {
            T2.text = ("Idle");
        }
        else
        {
            if (TG2.grabbed == true)
            {
                T2.text = ("Grabbed");
            }
            else
            {
                T2.text = ("Grabbing...");
            }
        }
    }
}
