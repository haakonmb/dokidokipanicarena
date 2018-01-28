using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    GameObject stack;
    Transform trans;
    Vector3 v3 = new Vector3(0, 10, 0);
    float timer;

	// Use this for initialization
	void Start () {
        stack = gameObject;
        Debug.Log(stack.name);
        trans = stack.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5f)
        {

            timer = 0;
            trans.Rotate(Vector3.up * (Time.deltaTime * 200));
        }
    }
}
