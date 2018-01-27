using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_movement : MonoBehaviour {

    private Rigidbody rb; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0.1f, 0, 0);
	}
}
