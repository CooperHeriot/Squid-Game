using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSegment : MonoBehaviour
{
    public ArmBoost AB;

    public HingeJoint HJ;
    public JointSpring HS;
    // Start is called before the first frame update
    void Start()
    {
        HJ = GetComponent<HingeJoint>();

        HS = HJ.spring;
    }

    // Update is called once per frame
    void Update()
    {
        HS = HJ.spring;
        /*if (AB.release == true)
        {
            HS.targetPosition = 0;            
        } else
        {
            HS.targetPosition = AB.currentArmRot;
        }*/

        HS.targetPosition = 90;

        HS.damper = 234;

        HJ.useSpring = false;

    }
}
