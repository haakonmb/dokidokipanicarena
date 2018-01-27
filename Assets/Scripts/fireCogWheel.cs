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
            damage++;
        }

        if(Input.GetButtonUp("Fire1")) {
            Rigidbody cw = Instantiate(cogwheel, transform.position, Quaternion.identity);
            cw.GetComponent<Ammunition_CogWheel>().SetDamage(damage);

            bool onBeat = transform.Find("GameController").GetComponent<DokiDoki>().CheckBeat();
            if (!onBeat) transform.Find("FirstPersonCharacter").GetComponent<Health>().TakeDamage(10);
            cw.GetComponent<Ammunition_CogWheel>().onBeat = onBeat;

            cw.AddForce(transform.forward * 2000);
            damage = 10; 
        }
    }
}
