using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    Vector3 strtPos;
    void Start()
    {
        //Vector3 pos = transform.position;
        strtPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if (CameraClearFlags=)
         gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.02f, gameObject.transform.position.y, gameObject.transform.position.z);
        // gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.01f, gameObject.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = strtPos;


    }
}
