using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject AboutMenu;
    public GameObject LevelsMenu;

    public void Play()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OpenLevels()
    {
        LevelsMenu.SetActive(true);
    }

    public void BackLevels()
    {
        LevelsMenu.SetActive(false);
    }

    public void OpenAbout()
    {
        AboutMenu.SetActive(true);
    }

    public void BackAbout()
    {
        AboutMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
