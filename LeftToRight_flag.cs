using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftToRight_flag : MonoBehaviour
{//Beginning of leftToRight_Oscillating class

    public Rigidbody rigidBodyBeingMoved; //The object being moved
    public float timer, timeBetweenSwitches;
    public bool moveRight;
    public float speed;
    public static bool FlagMotor2Arduino;


    // Start is called before the first frame update
    void Start()
    {//Beginning of Start function

        timer = timeBetweenSwitches;

    }//End of Start function

    private void Update()
    {//Beginning of Update function
        FlagMotor2Arduino = Automations.flagMotor1Arduino;

        if (FlagMotor2Arduino)
        {
            timer -= Time.deltaTime;
        }


    }//End of Update function

    // Update is called once per frame
    void FixedUpdate()
    {//Beginning of FixedUpdate function

        FlagMotor2Arduino = Automations.flagMotor2Arduino;
        if (FlagMotor2Arduino)
        {
            if (moveRight == true)
            {//Beginning of if (moveRight == true)

                if (timer > 0)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * speed);
                }
                else
                {

                    moveRight = false;
                    timer = timeBetweenSwitches;
                }

            }//End of if (moveRight == true)

            if (moveRight == false)
            {//Beginning of if (moveRight == false)

                if (timer > 0)
                {

                    transform.Translate(Vector3.left * Time.deltaTime * speed);
                }
                else
                {

                    moveRight = true;
                    timer = timeBetweenSwitches;
                }

            }//End of if (moveRight == false)

        }//End of FixedUpdate function

    }

            


}//End of leftToRight_Oscillating class
