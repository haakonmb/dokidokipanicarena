using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition_CogWheel : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter(Collision collision) {
        Debug.Log("You've hit the " + collision.gameObject.name.ToLower() + ". Well done.");
    }
}
