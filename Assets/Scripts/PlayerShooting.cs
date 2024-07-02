using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public AudioSource shootAudio;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;

    void Start()
    {
        // Si el AudioSource está en el mismo GameObject
        shootAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        // Ajusta la velocidad del proyectil en el eje X para que salga hacia la derecha
        rb.velocity = transform.right * projectileSpeed;

        // Reproducir sonido
        shootAudio.Play();
    }
}
