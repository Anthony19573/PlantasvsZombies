using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int maxHits = 15; // Número máximo de impactos que el enemigo puede resistir
    private int currentHits; // Número actual de impactos recibidos

    void Start()
    {
        currentHits = 0; // Inicializar el contador de impactos
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ProjectilePlayer"))
        {
            // Incrementar el contador de impactos
            currentHits++;
            

            // Verificar si el enemigo ha recibido suficientes impactos
            if (currentHits >= maxHits)
            {
                // Aquí puedes agregar lógica adicional, como reproducir efectos de sonido o animaciones
                Debug.Log("");
                Destroy(gameObject); // Destruir el enemigo
            }
            else
            {
                // Si no ha recibido suficientes impactos, solo destruir el proyectil del jugador
                Destroy(other.gameObject); // Proyectil del jugador
            }
        }
    }
}
