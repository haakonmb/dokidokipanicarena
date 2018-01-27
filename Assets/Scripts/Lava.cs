using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {


    public int damagePerTick = 1;
    public float damageTickTime = 1.0f;

    private List<Player> playersInLava = new List<Player>();
    private float damageTickCooldown;

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
            playersInLava.Add(player);

        damageTickCooldown = 0.0f;
    }

    private void OnTriggerExit(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
            playersInLava.Remove(player);
    }


	void Update () {
		
        if (playersInLava.Count > 0)
        {
            if (damageTickCooldown <= 0.0f)
            {
                foreach (Player player in playersInLava)
                {
                    player.AlterHealth(-10 * damagePerTick);
                }

                damageTickCooldown = damageTickTime;
            }
            else {
                damageTickCooldown -= Time.deltaTime;
            }
        }
	}
}
