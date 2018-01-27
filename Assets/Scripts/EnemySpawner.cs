using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject GaOb;
    public float initialSpawnTimer = 10f;
    float spawnTimer = 10f;
    int spawn = 1;

	// Use this for initialization
	void Start () {
        spawnTimer = initialSpawnTimer;
	}

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer <= 0)
        {
            GameObject cw = Instantiate(GaOb, spawnLoc(), Quaternion.identity);
            spawnTimer = initialSpawnTimer;
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
    Vector3 spawnLoc()
    {
        Vector3 loc = new Vector3(20, 0, 20);
        switch (spawn)
        {
            case 1:
                loc = new Vector3(0, 0.75f, 25);
                spawn += 1;
                break;
            case 2:
                loc = new Vector3(-20, 0.75f, 20);
                spawn += 1;
                break;
            case 3:
                loc = new Vector3(-25, 0.75f, 5);
                spawn += 1;
                break;
            case 4:
                loc = new Vector3(-20, 0.75f, -10);
                spawn += 1;
                break;
            case 5:
                loc = new Vector3(0, 0.75f, -20);
                spawn += 1;
                break;
            case 6:
                loc = new Vector3(20, 0.75f, -10);
                spawn += 1;
                break;
            case 7:
                loc = new Vector3(25, 0.75f, 5);
                spawn += 1;
                break;
            case 8:
                loc = new Vector3(20, 0.75f, 20);
                spawn = 1;
                break;
            default:
                Debug.Log("Spawn variable is " + spawn);
                break;
        }

        return loc;
    }
}
