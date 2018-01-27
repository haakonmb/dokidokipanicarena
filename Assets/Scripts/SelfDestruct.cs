using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

    // Use this for initialization

	void Start () {
        Destroy(gameObject, 0.04f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You've hit the " + collision.gameObject.name.ToLower() + ". Well done.");
        if (collision.gameObject.tag == "Base")
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(1);

                Destroy(gameObject);
        }
    }
}
