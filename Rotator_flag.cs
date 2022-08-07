using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_flag : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    public static bool FlagMotor4Arduino;

    // Update is called once per frame
    void Update()
    {
        FlagMotor4Arduino = Automations.flagMotor4Arduino;
        if (FlagMotor4Arduino)
        {
            // to keep it consistance ACROSS ALL FRAMERATES
            // transform.Rotate(_rotation *Time.deltaTime );
            Vector3 position = gameObject.GetComponent<Renderer>().bounds.center;
            // degreesPerSecond=100 
            gameObject.transform.RotateAround(position, _rotation, 100 * Time.deltaTime);

        }


        
    }
}

