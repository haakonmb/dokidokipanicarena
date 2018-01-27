using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Killed of teh -> + other");
            other.GetComponent<Player>().AlterHealth(-999999);
        }
        Debug.Log("NICE AS FUUUGE, DeathTrigger");
    }
}