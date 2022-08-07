using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround_flag : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject pivotObject;
    public static bool FlagMotor4Arduino;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FlagMotor4Arduino = Automations.flagMotor4Arduino;
        if (FlagMotor4Arduino)
        {
            transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
        }
    }
}

