using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfer_run : MonoBehaviour {

    public float Speed = 0.001f;
    public GameObject player;
    public Rigidbody rb;

    void Start () {

        rb = GetComponent<Rigidbody>();

    }

    void Example()
    {
        
    }

    void Update () {

        if (Input.GetKey(KeyCode.UpArrow)){
            //this.transform.Translate(0, 0, 1, Space.Self);
            //rb.AddForce(0,0,thrust, ForceMode.Acceleration);
            rb.AddForce(transform.forward * Speed, ForceMode.Impulse);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           this.gameObject.transform.Rotate (0, -1, 0); 
        }


    }
    
}
