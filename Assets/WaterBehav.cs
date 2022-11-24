using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBehav : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Gravity>() != null)
        {
            other.gameObject.GetComponent<Gravity>().inWater = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Gravity>() != null)
        {
            other.gameObject.GetComponent<Gravity>().inWater = false;
        }
    }
}
