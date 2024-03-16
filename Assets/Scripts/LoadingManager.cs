using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public GameObject LoadingScreen;
    [SerializeField] private Slider LoadingBarFill;
    public float speed;

   


    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }

    public void LoadingScreenEnable()
    {
        LoadingScreen.SetActive(true);
    }

    IEnumerator LoadSceneAsync(int sceneId)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / speed);
            LoadingBarFill.value = progressValue;

            yield return null;
        }
    }
}
