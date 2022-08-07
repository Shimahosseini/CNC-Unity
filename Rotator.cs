using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    // Update is called once per frame
    void Update()
    {
        // to keep it consistance ACROSS ALL FRAMERATES
       // transform.Rotate(_rotation *Time.deltaTime );
        Vector3 position = gameObject.GetComponent<Renderer>().bounds.center;
        // degreesPerSecond=100 
        gameObject.transform.RotateAround(position, _rotation, 100 * Time.deltaTime);
    }
}
