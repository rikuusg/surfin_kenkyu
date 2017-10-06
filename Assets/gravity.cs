using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour {



	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {

        //Physics.gravity = new Vector3(0, -9.81f, 0);

        this.transform.Translate(0, -9.81f, 0, Space.Self);

    }
}
