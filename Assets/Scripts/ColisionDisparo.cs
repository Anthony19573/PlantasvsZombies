using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDisparo : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ProjectileEnemy"))
        {
            // Destruir el proyectil del enemigo y el proyectil del jugador
            Destroy(other.gameObject); // Proyectil del enemigo
            Destroy(gameObject); // Proyectil del jugador
        }
        else if (other.gameObject.CompareTag("ProjectilePlayer"))
        {
            // Destruir el proyectil del jugador y el proyectil del enemigo
            Destroy(other.gameObject); // Proyectil del jugador
            Destroy(gameObject); // Proyectil del enemigo
        }
    }
}
