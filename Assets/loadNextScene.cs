using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadNextScene : MonoBehaviour
{
    public PauseManager PM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>() != null && other.transform.tag == ("MainSquid"))
        {
            PM.loadScene();
        }
    }
}
