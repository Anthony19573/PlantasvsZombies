using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del enemigo (ajusta según tus necesidades)
    public Transform targetPoint; // Referencia al objeto vacío que representa X = -3.5

    void Update()
    {
        // Mover el enemigo hacia la izquierda
        Vector3 moveAmount = Vector3.left * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmount);

        // Verificar si la posición X es menor o igual a -3.5
        if (transform.position.x <= targetPoint.position.x)
        {
            // Destruir el objeto enemigo
            Destroy(gameObject);
        }
    }
}

