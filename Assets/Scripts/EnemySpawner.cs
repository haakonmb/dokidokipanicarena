using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody cw = Instantiate(rb, transform.position, Quaternion.identity);
    }

    Vector3 spawnLoc()
    {
        Vector3 loc = new Vector3(0, 0, 0);


        return loc;
    }
}
