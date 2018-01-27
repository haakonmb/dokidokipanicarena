using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireCogWheel : MonoBehaviour {
    public Rigidbody cogwheel;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Rigidbody cw = Instantiate(cogwheel, transform.position, Quaternion.identity);
            cw.AddForce(transform.forward * 2000);
        }
    }
}
