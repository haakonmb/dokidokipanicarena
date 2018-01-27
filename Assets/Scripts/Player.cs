using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;


public class Player : MonoBehaviour
{
    
    public int maxHealth;
    public Text currentHealthLabel;
    public Image deadScreen;
    public Slider healthSlider;

    private int currentHealth;
    public bool isDead;

    void Start()
    {
        currentHealth = maxHealth;
        isDead = false;
        UpdateGUI();
    }

    void UpdateGUI()
    {
        currentHealthLabel.text = currentHealth.ToString();
        deadScreen.gameObject.SetActive(isDead);
        healthSlider.value = currentHealth;

    }

    public void AlterHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        CheckDead();
        UpdateGUI();
    }

    private void CheckDead()
    {

        if (isDead)
            return;

        if (currentHealth == 0)
        {
            isDead = true;
            GetComponent<FirstPersonController>().enabled = false;
        }
    }

}