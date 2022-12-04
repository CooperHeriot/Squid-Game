using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehav : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject model, pivot, pivotPoint, rotModel;

    public float test;

    private Gravity grav;
    //rotation stuff
    //public float modelRotx, modelRoty;
    public Vector3 ModelRotV;
    public float turnSpeed;

    public float boostAm;
    public bool boost;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        grav = GetComponent<Gravity>();
    }

    void Update()
    {
        //rotModel.transform.localRotation = Quaternion.LookRotation(pivotPoint.transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
       
        if (grav.inWater == true)
        {
            Vector3 moveRot = new Vector3(x, 0, z);

            moveRot = Vector3.Normalize(moveRot);

            rb.AddForce(moveRot * speed, ForceMode.Acceleration);


            //rotation stuff

            /*if (Input.Key)
            {
                pivot.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveRot), 1);

                //rotModel.transform.rotation = Quaternion.LookRotation(moveRot);
            }*/
            rotModel.transform.rotation = Quaternion.Slerp(rotModel.transform.rotation, Quaternion.LookRotation(transform.position - pivotPoint.transform.position), turnSpeed * Time.deltaTime);

            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(transform.position - Target.transform.position), TurnSpeed * Time.deltaTime);
            //rotModel.transform.rotation = Quaternion.LookRotation(pivotPoint.transform.position);

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                //modelRoty = Mathf.Lerp(modelRoty, 0, turnSpeed * Time.deltaTime);
                ModelRotV = Vector3.Slerp(ModelRotV, new Vector3(0, 0, 0), turnSpeed * Time.deltaTime);
                pivot.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveRot), 1);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                //modelRoty = Mathf.Lerp(modelRoty, -180, turnSpeed * Time.deltaTime);
                ModelRotV = Vector3.Slerp(ModelRotV, new Vector3(0, 0, 180), turnSpeed * Time.deltaTime);
                pivot.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveRot), 1);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                //modelRotx = Mathf.Lerp(modelRotx, -90, turnSpeed * Time.deltaTime);
                ModelRotV = Vector3.Slerp(ModelRotV, new Vector3(0, 0, 90), turnSpeed * Time.deltaTime);
                pivot.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveRot), 1);
            }

            // Vector3 ModelRotV = new Vector3(modelRoty, modelRotx, 0);

            //ModelRotV = Vector3.Normalize(ModelRotV);

            model.transform.localRotation = Quaternion.Euler(ModelRotV);
            //transform.rotation = Quaternion.Lerp(transform.rotation, pivot.transform.rotation, 2f * Time.deltaTime);


           if (boost == true)
            {
                Vector3 direction = transform.position - pivotPoint.transform.position;

                rb.AddForce(direction * boostAm, ForceMode.VelocityChange);
                boost = false;
            }
        
        }


        //rb.AddTorque(0, test, 0);

        //test = Vector3.Angle(transform.position, pivotPoint.transform.position);
    }

    public void Boost(float _Amount)
    {
        boostAm = _Amount;

        boost = true;
    }
}
