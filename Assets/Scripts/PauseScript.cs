using UnityEngine;
public class PauseScript : MonoBehaviour
{

    public GameObject PausedPanel;
   

    private void Start()
    {
        PausedPanel.SetActive(false);
    }

    public void PauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            /* ActivateUI(true);*/
            AudioListener.pause = !AudioListener.pause;
            PausedPanel.SetActive(true);
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            /*ActivateUI(false);*/
            AudioListener.pause = !AudioListener.pause;
            PausedPanel.SetActive(false);
        }
    }

    /*void ActivateUI(bool active)
    {
        Canvas[] canvases = FindObjectsOfType<Canvas>();

        foreach (Canvas canvas in canvases)
        {
            canvas.enabled = active;

        }
    }*/
}

