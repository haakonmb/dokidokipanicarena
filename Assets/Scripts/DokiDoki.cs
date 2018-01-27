using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DokiDoki : MonoBehaviour {

    private float doki;
    public float bpm = 0.5f;
    public float offset; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        doki += Time.deltaTime;

        if(doki >= bpm) {
            Debug.Log(doki);
            doki -= doki;
        }
    }

    public float GetHeartbeat() {
        return doki; 
    }

    public bool CheckBeat() {
        return (doki >= bpm - offset && doki <= bpm + offset); 
    }
}
