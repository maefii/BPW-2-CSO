using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("forestDay");
    }

    public void OpenControlsMenu()
    {
        SceneManager.LoadScene("controlsMenu");
    }

    public void SwapToNight()
    {
        SceneManager.LoadScene("forestNight");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
