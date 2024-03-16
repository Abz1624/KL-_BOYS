using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig01 : MonoBehaviour
{
    /* [SerializeField] private GameObject UI_GameWin;
     public GameObject Bike;
     [SerializeField] GO go;
     public GameObject PauseBtn;
    */
    public GameObject levelPlace;
   


    private void Start()
    {
        //UI_GameWin.SetActive(false);
        levelPlace.SetActive(false);
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



        }
    }
}
