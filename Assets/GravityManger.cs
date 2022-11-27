using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManger : MonoBehaviour
{
    public float force;
    private float Forcee;

    //public List<GameObject> GravObjs;

    public Gravity[] gra;
    // Start is called before the first frame update
    void Start()
    {
        Forcee = force;

        gra = FindObjectsOfType<Gravity>();

        UpdateGravity();
    }

    // Update is called once per frame
    void Update()
    {
        if (force != Forcee)
        {
            UpdateGravity();
            Forcee = force;
        }
    }

    void UpdateGravity()
    {
        foreach (Gravity gravity in gra)
        {
            gravity.force = force;
        }
    }
}
