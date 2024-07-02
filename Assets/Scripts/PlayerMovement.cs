using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    public float minY = -4; // Límite inferior en el eje Y
    public float maxY = 4; // Límite superior en el eje Y

    void Update()
    {
        // Obtener la entrada vertical (W/S o Flechas arriba/abajo)
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular el desplazamiento vertical
        Vector3 moveDirection = new Vector3(0f, verticalInput, 0f);
        Vector3 moveAmount = moveDirection * moveSpeed * Time.deltaTime;

        // Calcular la nueva posición
        Vector3 newPosition = transform.position + moveAmount;
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY); // Restringir al rango permitido

        // Mover el jugador
        transform.position = newPosition;
    }
}
