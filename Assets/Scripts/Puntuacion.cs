using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public Text ScoreText; // Referencia al objeto Text que muestra el marcador
    private int score = 0; // Puntuación actual

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Destruir el objeto enemigo
            Destroy(other.gameObject);

            // Sumar 20 puntos al marcador
            score += 20;
            UpdateScoreText();
        }
    }

    // Actualiza el marcador en pantalla
    void UpdateScoreText()
    {
        ScoreText.text = "Score: " + score;
    }
}
