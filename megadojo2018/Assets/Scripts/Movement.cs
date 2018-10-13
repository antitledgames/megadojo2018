using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 1.0f;

    void Start()
    {
   
    }


    void Update ()
    {

        if (Input.GetKey(KeyCode.A) == true)
        {
            gameObject.GetComponent<Transform>().position -= new Vector3(speed, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            gameObject.GetComponent<Transform>().position += new Vector3(speed, 0.0f, 0.0f);

        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            gameObject.GetComponent<Transform>().position -= new Vector3(0.0f, speed, 0.0f);
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            gameObject.GetComponent<Transform>().position += new Vector3(0.0f, speed, 0.0f);

        }


    }
}
