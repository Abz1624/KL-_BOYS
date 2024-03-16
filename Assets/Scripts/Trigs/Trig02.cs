using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trig02 : MonoBehaviour
{
    [SerializeField] BikeController bikeController;
    /* [SerializeField] private GameObject UI_GameWin;
     public GameObject Bike;
     [SerializeField] GO go;
     public GameObject PauseBtn;
    */
    public GameObject levelPlace;
    [SerializeField] private GameObject LevelTrasition;
    public AudioSource LeavesTrasition;

    Animator Anim;
   


    private void Start()
    {
        //UI_GameWin.SetActive(false);
        levelPlace.SetActive(false);
        Anim = LevelTrasition.gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            /*if(go.isGameover == false)
            {
                Debug.Log("You win sir...");
                UI_GameWin.SetActive(true);
                PauseBtn.SetActive(false);
                Destroy(Bike);
            }*/

            levelPlace.SetActive(true);
            StartCoroutine(Transition());



        }
    }

     public IEnumerator Transition()
    {
        yield return new WaitForSeconds(2);
        
        LeavesTrasition.Play();
        Anim.SetBool("isTrasition", true);
        yield return new WaitForSeconds(2f);
        Debug.Log("adtha scene");
        bikeController.GameOver();
        NextScene();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
