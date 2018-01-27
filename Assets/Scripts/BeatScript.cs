using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScript : MonoBehaviour {

    //Tha Beat
    private Beat beat;
    //Object implementing OnNextBeat method and relevant code
    private FuckMeUpBatman fmupbman;
    //Any usable fields need to be protected
    protected bool flip = true;


	// Use this for initialization
	void Start () {

        //When starting object pass in reference to containing object.
        fmupbman = new FuckMeUpBatman(this);
        //Find the beats
        beat = FindObjectOfType<Beat>();

        //Add the code you want done to the beats!!
        beat.AddListener(fmupbman);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //This is the internal class containing what you want to change on each beat. It needs to implemment the BeatListener interface.
    private class FuckMeUpBatman : BeatListener
    {
        //Reference of type of containing object. In this base Beatscript. If internal class of for example a BatmanEatsHoney the type would be BatmanEatsHoney
        BeatScript obj;

        //The constructor needs to know what to do with the reference
            public FuckMeUpBatman(BeatScript b)
        {
            obj = b;

        }

        //The mandated method from the BeatListener interface. Put your stuff here.
        public void OnNextBeat()
        {
            //If you want to interact with the containing object it can be done like this
            obj.flip = !obj.flip;
            //Or like this
            Debug.Log(obj.flip);


        }
    }



}
