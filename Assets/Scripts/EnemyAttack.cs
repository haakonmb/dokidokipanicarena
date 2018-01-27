using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public Rigidbody rb;
    float timer = 0f;
    public float frequency = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= frequency)
        {
            Rigidbody cw = Instantiate(rb, transform.position, Quaternion.identity);
            timer = 0f;
        }
    }
}
