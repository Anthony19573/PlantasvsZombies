using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
 public void StartGame()
 {
 // el nombre de tu escena de juego
 SceneManager.LoadScene("patio");
 }
 public void QuitGame()
 {
 Debug.Log("Salir presionado");
 //Application.Quit();//no tiene efecto en webgl
 Application.OpenURL("https://unity.com/es"); }
}
