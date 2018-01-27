using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireCogWheel : MonoBehaviour {

    public Rigidbody cogwheel;

    private int damage = 10;

    // Use this for initialization
    private void Start () {
		
	}

    // Update is called once per frame
    private void Update() {
        if (Input.GetButton("Fire1")) {
            // Når secondary audio track er implementert, unmute her
            damage++;
        }

        if(Input.GetButtonUp("Fire1")) {
            // Når secondary audio track er implementert, mute her

            Rigidbody cw = Instantiate(cogwheel, transform.position, Quaternion.identity);
            cw.GetComponent<Ammunition_CogWheel>().SetDamage(damage);
            cw.AddForce(transform.forward * 2000);
            damage = 10;

            if (GameObject.Find("BackgroundMusic").GetComponent<DokiDoki>().CheckBeat()) {
                cw.GetComponent<Ammunition_CogWheel>().onBeat = true;
                Debug.Log("Good!");
            } else {
                //Her kan skade på spille kommenteres ut
                GetComponentInParent<Player>().AlterHealth(-10);
                Debug.Log("Bad!");
            }
        }
    }
}
