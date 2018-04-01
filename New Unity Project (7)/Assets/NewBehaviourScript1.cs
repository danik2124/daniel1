using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    public Rigidbody rbl;
    float rotX;
    float rotY;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotX = Input.GetAxis("Mouse X") ;
        rotY = Input.GetAxis("Mouse Y") ;
        transform.Rotate(0, rotX, 0);
        if (Input.GetKey(KeyCode.Space))
        {
            rbl.AddForce(0, 0, 14);
        }
	}
}
