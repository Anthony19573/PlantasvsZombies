using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab del enemigo
    public float spawnInterval = 5f; // Intervalo de spawn (en segundos)
    public float moveSpeed = 2f; // Velocidad de movimiento horizontal

    private float nextSpawnTime; // Tiempo para el próximo spawn

    void Start()
    {
        // Inicializar el tiempo para el primer spawn
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        // Verificar si es hora de hacer spawn
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            // Calcular el próximo tiempo de spawn
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnEnemy()
    {
        // Calcular la posición de spawn (horizontal fija en X=10, Y aleatorio)
        float[] validYPositions = { -3.5f, -1.7f, -0.2f, 1.6f, 3.3f };
        float randomY = validYPositions[Random.Range(0, validYPositions.Length)];
        Vector3 spawnPosition = new Vector3(10f, randomY, transform.position.z);

        // Crear el enemigo desde el prefab
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Configurar la velocidad de movimiento horizontal
        Rigidbody2D rbEnemy = newEnemy.GetComponent<Rigidbody2D>();
        rbEnemy.velocity = Vector2.left * moveSpeed;
    }
}
