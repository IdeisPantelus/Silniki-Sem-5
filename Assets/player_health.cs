using System;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int MaxHealth = 10;
    private int health;
    public event Action Death;
    public event Action<int> OnAddHealth;
    public event Action<int> OnHealthInnit;
   
    
    void Start()    // stabilizing starting Health 
    {
        health = MaxHealth;
        OnHealthInnit?.Invoke(health);  //sending it into game
    }


    public void AddHealth(int healthToAdd)
    {
        health += healthToAdd;
        OnAddHealth?.Invoke(health);
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
