using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dfg : MonoBehaviour
{
    public GameObject line, midPoint;
    public GameObject dragObj;

    public GameObject draggedObj;
    public bool dragging;

    public Vector3 screenPos, worldPos;
    public float dist;
    public Camera cam;
    Ray beam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        beam = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(beam, out hit) && dragging == false)
        {
            screenPos = Input.mousePosition;
            screenPos.z = 1;

            worldPos = cam.ScreenToWorldPoint(screenPos);

            dragObj.transform.position = worldPos;
            /*
            dragObj.transform.position = hit.point;
            dist = Vector3.Distance(transform.position, dragObj.transform.position);
            /*if (hit.collider.gameObject.GetComponent<Rigidbody>() != null)
            {
                if (Input.GetMouseButton(0))
                {
                    if (dragging == false)
                    {
                        draggedObj = hit.collider.gameObject;
                    }
                    dragging = true;
                } else
                {
                    draggedObj = null;
                    dragging = false;
                }
                
            }*/
        }
        else
        {
            screenPos = Input.mousePosition;
            screenPos.z = 1;

            worldPos = cam.ScreenToWorldPoint(screenPos);

            dragObj.transform.position = worldPos;
        }
        /*
        //selection
        if (Input.GetMouseButton(0))
        {
            if (dragging == false && hit.collider.gameObject.GetComponent<Rigidbody>() != null)
            {
                draggedObj = hit.collider.gameObject;
            }
            dragging = true;
        }
        else
        {
            draggedObj = null;
            dragging = false;
            line.transform.localScale = Vector3.zero;
        }

        //the dragging part
        if (dragging == true)
        {
            Vector3 pullRot = dragObj.transform.position - draggedObj.transform.position;
            draggedObj.GetComponent<Rigidbody>().AddForce(pullRot * Vector3.Distance(draggedObj.transform.position, dragObj.transform.position) * 4);

            dist += Input.GetAxis("Mouse ScrollWheel") * 4;

            midPoint.transform.position = new Vector3((dragObj.transform.position.x + draggedObj.transform.position.x) / 2, (dragObj.transform.position.y + draggedObj.transform.position.y) / 2, (dragObj.transform.position.z + draggedObj.transform.position.z) / 2);

            line.transform.position = midPoint.transform.position;
            line.transform.rotation = Quaternion.LookRotation(dragObj.transform.position - draggedObj.transform.position);
            line.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, Vector3.Distance(dragObj.transform.position, draggedObj.transform.position));
        }
        */
    }
}
