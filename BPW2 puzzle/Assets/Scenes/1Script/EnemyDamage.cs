using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth; //zoekt naar playerHealth script

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // als de speler collide met enemy (object)
        {
            playerHealth.TakeDamage(1); // Gaat er 1 health af 
            // Is de speler af. Game reset(Game over screen, "Try again")
        }
    }
}
