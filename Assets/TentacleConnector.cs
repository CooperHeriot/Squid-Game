using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleConnector : MonoBehaviour
{
    public GameObject bot;
    private GameObject Bit;

    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        Bit = Instantiate(bot, transform.position, transform.rotation);
        target = GetComponent<HingeJoint>().connectedBody.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Bit.transform.position = new Vector3((transform.position.x + target.transform.position.x) / 2, (transform.position.y + target.transform.position.y) / 2, (transform.position.z + target.transform.position.z) / 2);

        Bit.transform.rotation = Quaternion.LookRotation(transform.position - target.transform.position);

        float dist = Vector3.Distance(transform.position, target.transform.position);

        Bit.transform.localScale = new Vector3(Bit.transform.localScale.x, Bit.transform.localScale.y, dist);
    }
}
