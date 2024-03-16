using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] BikeController bikeController;
    public GameObject UI_GameOverPanel;
    public bool isGameover = false;
    public GameObject Bike;

    

    private void Start()
    {
        UI_GameOverPanel.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("You Lose Bitch :|");
            
            bikeController.GameOver();
            UI_GameOverPanel.SetActive(true);
            isGameover =true;
            Bike.SetActive(false);

        }
    }

    

}
