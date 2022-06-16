using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnePlayerGame()
    {
        SceneManager.LoadScene("TankSceneOnePlayer");
    }

    public void TwoPlayerGame()
    {
        SceneManager.LoadScene("TankSceneTwoPlayer");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
