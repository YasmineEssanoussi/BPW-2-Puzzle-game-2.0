using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //Game over screen
    public static event Action OnPlayerCaught;

    //player Health
    public int health;
    public int maxHealth = 1;                              

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage (int amount) 
    {
        health -= amount;
        if (health < 0)
        {
            health = 0;
            OnPlayerCaught?.Invoke(); // Game over screen
        }
    }
}
