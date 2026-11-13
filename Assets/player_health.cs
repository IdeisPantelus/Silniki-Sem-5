using System;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int MaxHealth = 10;
    private int health;
    public event Action Death;
    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddHealth(int healthToAdd)
    {
        health += healthToAdd;
        if (health > MaxHealth)
        {
            health = MaxHealth;
        }
        else if (health <= 0)
        {
            Die();
        }

        Debug.Log(health);
    }

    private void Die()
    {
        health = MaxHealth;
        Death?.Invoke();
    }

}
