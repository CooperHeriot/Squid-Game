using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePlayer : MonoBehaviour
{
    public float Timer;
    public float timeDown;
    public SquidMasterControl suid;
    public bool onStart;
    // Start is called before the first frame update
    void Start()
    {
        suid = GameObject.Find("SquidContainer").GetComponent<SquidMasterControl>();

        timeDown = Timer;

        if (onStart)
        {
            Activate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeDown >= 0)
        {
            timeDown -= 1 * Time.deltaTime;
        } else
        {
            suid.onOff = false;
        }


    }

    private void OnTriggerStay(Collider other)
    {
        Activate();
    }

    public void Activate()
    {
        suid.onOff = true;
        timeDown = Timer;
    }
}
