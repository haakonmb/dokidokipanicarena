using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour {

    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public bool isBase = false;
    public Text currentHealthLabel;
    public Image deadScreen;
    public Slider healthSlider;
    bool isDead;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage (int amount) {
        currentHealth -= amount;
        if (currentHealth <= 0) {
            currentHealth = 0;
            Debug.Log("Dead!");
            if (!isBase) {
                Destroy(gameObject);
            } else {
                isDead = true;
            }
        }
        if (isBase)
        {
            currentHealthLabel.text = currentHealth.ToString();
            deadScreen.gameObject.SetActive(isDead);
            healthSlider.value = currentHealth;
        }


        Debug.Log("Took " + amount + " damage!");
        Debug.Log(currentHealth + " health left");
    }
}
