using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BikeController : MonoBehaviour
{
    //[SerializeField] GameOverScript gameoverScript;

    public float Speed = 1500;
    public float RotationSpeed = 1000;
    public WheelJoint2D BackWheel;
    public WheelJoint2D FrontWheel;
    public Rigidbody2D rb;
    public ParticleSystem VFX_StrokeSmoke;
    //public bool isGrounded = false;
    public ParticleSystem VFX_PlayerNeckBlood;


    public float Movement = 0f;
    private float Rotation = 0f;
    


    private void Awake()
    {
        
    }


    private void Update()
    {
        Movement = -Input.GetAxisRaw("Vertical") * Speed;
        Rotation = -Input.GetAxisRaw("Horizontal");

        if (rb.velocity.magnitude > 0)
        {
            VFX_StrokeSmoke.Play();
        }
    }
    private void FixedUpdate()
    {
        if(Movement == 0)
        {
            BackWheel.useMotor = false;
            FrontWheel.useMotor = false;
            
        }
        else
        {
            BackWheel.useMotor = true;
            FrontWheel.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = Movement, maxMotorTorque = 2000 };
            BackWheel.motor = motor;
            FrontWheel.motor = motor;
        }
        rb.AddTorque(Rotation * Speed * Time.deltaTime);

        
      

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player") 
        {

            
        }
    }
    public void GameOver()
    {
        Speed = 0f;
        RotationSpeed = 0f;
        VFX_PlayerNeckBlood.Play();
       // rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
    }

    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    

}
