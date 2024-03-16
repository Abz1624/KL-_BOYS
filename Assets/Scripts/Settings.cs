using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    Animator Anim;
    public bool isSetting = false;

    public GameObject Volume;
    public GameObject MuteVolume;
    public GameObject GotoHomePanel;


    private void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    public void openSettings()
    {
        if (isSetting == false)
        {
            Anim.Play("openSettings_Anim");
            StartCoroutine(TimeGap());
        }
        if (isSetting == true)
        {
            Anim.Play("closeSettings_Anim");
            isSetting = false;
        }
    }

    IEnumerator TimeGap()
    {
        yield return new WaitForSeconds(2f);
        isSetting = true;
    }

    public void LoadNextScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
        AudioListener.pause = !AudioListener.pause;
    }

    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void MuteAllAudio()
    {
      AudioListener.pause = !AudioListener.pause;
      MuteVolume.SetActive(true);
        Volume.SetActive(false);
    }
    public void UnMuteAllAudio()
    {
        AudioListener.pause = !AudioListener.pause;
        MuteVolume.SetActive(false);
        Volume.SetActive(true);
    }

    public void GotoHome()
    {     
            AudioListener.pause = !AudioListener.pause;
            GotoHomePanel.SetActive(true); 
    }

    public void nohome()
    {
            AudioListener.pause = !AudioListener.pause;
            GotoHomePanel.SetActive(false);
    }

    
}




