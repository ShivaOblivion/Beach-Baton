using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int maxHeart = 100;
    public int currentHeart;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)       
    {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);

    }