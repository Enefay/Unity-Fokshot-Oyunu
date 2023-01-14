using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Bolum1");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AyarlarGit()
    {
        SceneManager.LoadScene("Ayarlar");
    }
}
