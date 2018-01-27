﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition_CogWheel : MonoBehaviour {

    private Rigidbody rb;
    private bool onBeat = false;
    private float countdown = 5;
    private int damage = 50;

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
        if (collision.gameObject.tag == "Enemy") {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);

            if (onBeat) {

            } else {
                Destroy(gameObject);
            }
        }
    }
}
