using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DokiDoki : MonoBehaviour {

    private float doki;
    private AudioSource source;
    private ArrayList beats; 
    public float bpm = 0.5f;
    public float offset; 

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        beats = new ArrayList();
        for (float b = 0.0f; b - 1.0f <= source.clip.length; b += 0.5f) {
            beats.Add(b);
            beats.Add(b - offset);
            beats.Add(b + offset);
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        doki = source.time;
	}

    public float GetHeartbeat() {
        return doki;
    }

    public bool CheckBeat() {
        return beats.Contains(Truncate(doki,1));
    }

    private float Truncate(float value, int digits) {
        double mult = Math.Pow(10.0, digits);
        double result = Math.Truncate(mult * value) / mult;
        return (float)result;
    }
}
