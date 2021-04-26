using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    void start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
        
    }    
    public void Game()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Jugar()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Instrucciones()
    {
        
    }
    public void Salir()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        
    }
}
