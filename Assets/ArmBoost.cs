using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmBoost : MonoBehaviour
{
    public PlayerBehav pb;

    public float chargeSpeed;

    public float armRotValue;
    public float boostAmount;

    public bool release;

    public float currentArmRot, currentBoostAmount;

   // public float holdPercentage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBoostAmount < 0)
        {
            currentBoostAmount = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (release == false)
            {
                currentBoostAmount = Mathf.Lerp(currentBoostAmount, boostAmount, chargeSpeed * Time.deltaTime);
                currentArmRot = Mathf.Lerp(currentBoostAmount, armRotValue, chargeSpeed * (armRotValue / 10) * Time.deltaTime);
            }
            if (currentBoostAmount >= (boostAmount - (boostAmount / 10)))
            {
                release = true;
            }    
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            release = true;
        }

        if (release == true)
        {
            pb.Boost(-currentBoostAmount / 10);

            currentBoostAmount = Mathf.Lerp(currentBoostAmount, 0, chargeSpeed * 3 * Time.deltaTime);
            currentArmRot = 0;

            if (currentBoostAmount <= ((boostAmount / 10)))
            {
                release = false;

                currentBoostAmount = 0;
            }
        }


    }
}
