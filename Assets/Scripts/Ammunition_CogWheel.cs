using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition_CogWheel : MonoBehaviour {

    private Rigidbody rb;
    private float countdown = 5;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;

        if (countdown <= 0.0) Destroy(gameObject);
	}

    void OnCollisionEnter(Collision collision) {
        Debug.Log("You've hit the " + collision.gameObject.name.ToLower() + ". Well done.");
        //if (rb.transform.parent.tag == "Player" && collision.gameObject.tag == "Enemy") collision.gameObject.damage(5);

        //Destroy(gameObject);
    }
}
