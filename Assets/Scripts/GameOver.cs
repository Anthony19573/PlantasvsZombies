using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] Plants; // Arreglo de las plantas
    public string mainMenuSceneName = "MainMenu"; // Nombre de la escena del menú principal

    void Update()
    {
        // Verificar si todas las plantas han sido destruidas
        bool allPlantsDestroyed = true;
        foreach (var Plant in Plants)
        {
            if (Plant != null) // Si la planta no ha sido destruida
            {
                allPlantsDestroyed = false;
                break; // Salir del bucle
            }
        }

        // Si todas las plantas han sido destruidas, mostrar "Game Over" y cargar el menú principal
        if (allPlantsDestroyed)
        {
            Debug.Log("¡Game Over!");
            LoadMainMenu();
        }
    }

    void LoadMainMenu()
    {
        // Cargar la escena del menú principal
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
