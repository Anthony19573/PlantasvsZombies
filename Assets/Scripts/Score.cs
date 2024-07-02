using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText; // Referencia al texto que muestra el puntaje
    private int score = 0; // Puntaje inicial

    private float timePassed = 0f; // Tiempo transcurrido en segundos

    void Update()
    {
        // Sumar 5 puntos por cada segundo que pasa
        timePassed += Time.deltaTime;
        int seconds = Mathf.FloorToInt(timePassed);
        int pointsPerSecond = 1 * seconds;

        // Actualizar el puntaje en el texto
        score = pointsPerSecond;
        ScoreText.text = $"Score: {score}";
    }
}
