using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    public int healAmount = 2;

    void OnTriggerEnter(Collider other)
    {

        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            player.AlterHealth(healAmount);
            gameObject.SetActive(false);
        }

    }

}