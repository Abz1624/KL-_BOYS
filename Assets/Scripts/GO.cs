using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using Cinemachine;

public class GO : MonoBehaviour
{
    [SerializeField] BikeController bikeController;
    public GameObject UI_GameOverPanel;
    public AudioSource HeadCrack;
    public bool isGameover = false;
    public GameObject PauseBtn;
    public GameObject waterSplash;
    public GameObject followObj;
    public AudioSource bikeAudio01;
    public AudioSource bikeAudio02;
   



    private void Start()
    {
        UI_GameOverPanel.SetActive(false);
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "water")
        {
            StartCoroutine(fallinWater());
            Vector2 touchPosition = collider.ClosestPoint(transform.position);
            Debug.Log("Fall in water hehee...");
            Destroy(followObj);
            bikeAudio01.enabled = false;
            bikeAudio02.enabled = false;
            GameObject vfx = Instantiate(waterSplash, touchPosition, Quaternion.identity);
            vfx.GetComponent<VisualEffect>().Play();
            

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("You Lose Bitch :|");

            bikeController.GameOver();
            UI_GameOverPanel.SetActive(true);
           if(isGameover == false)
            {
                HeadCrack.Play();
                isGameover = true;
                PauseBtn.SetActive(false);
                StartCoroutine(soundoff());
            }
            

        }

        
    }


    IEnumerator soundoff()
    {
        yield return new WaitForSeconds(1.5f);
        HeadCrack.Stop();
    }
    IEnumerator fallinWater()
    {
      yield return new WaitForSeconds(1);
        bikeController.GameOver();
        UI_GameOverPanel.SetActive(true);
    }


}
