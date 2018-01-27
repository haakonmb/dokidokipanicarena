using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour {

    // Use this for initialization
    Animator anim = new Animator();

	void Start () {
        anim = GetComponent<Animator>();
        anim.StartPlayback();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
