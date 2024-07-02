using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject EnemyProjectilePrefab; // Prefab del proyectil
    public float minShootInterval = 1f; // Intervalo mínimo entre disparos
    public float maxShootInterval = 3f; // Intervalo máximo entre disparos
    private float nextShootTime; // Tiempo para el próximo disparo
    public float projectileSpeed = 10f;

    void Start()
    {
        // Inicializar el tiempo para el primer disparo
        nextShootTime = Time.time + Random.Range(minShootInterval, maxShootInterval);
    }

    void Update()
    {
        // Verificar si es hora de disparar
        if (Time.time >= nextShootTime)
        {
            Disparar();
            // Calcular el próximo tiempo de disparo aleatoriamente
            nextShootTime = Time.time + Random.Range(minShootInterval, maxShootInterval);
        }
    }

    void Disparar()
    {
        // Crear el proyectil desde el prefab
        GameObject nuevoProyectil = Instantiate(EnemyProjectilePrefab, transform.position, Quaternion.identity);

        // Aplicar velocidad hacia la izquierda
        Rigidbody2D rbProyectil = nuevoProyectil.GetComponent<Rigidbody2D>();
        rbProyectil.velocity = Vector2.left * 10f; // Ajusta la velocidad según tus necesidades
    }
}
