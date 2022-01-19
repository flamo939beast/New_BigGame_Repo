using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDamageScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar HealthBar;
    public GameObject gameOverText;
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemies"))
        {
            TakeDamage(20);
        }

        if (currentHealth <= 0)
        {
            Wall.SetActive(false);
            Time.timeScale = 0;
            gameOverText.SetActive(true);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthBar.setHealth(currentHealth);
    }

   
}

