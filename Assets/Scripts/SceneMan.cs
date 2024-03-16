using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    public GameObject uiCredits;

    public void LoadNextScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void ExitGame()
    {
        Debug.Log("Get out bitch....");
        Application.Quit();
    }

    public void CreditstoHome()
    {
        uiCredits.SetActive(false);
    }
    public void toCredits()
    {
        uiCredits.SetActive(true);
    }
    public void insta()
    {
        string instagram = "https://www.instagram.com/___.abz.__/";
        Application.OpenURL(instagram);
    }
}
