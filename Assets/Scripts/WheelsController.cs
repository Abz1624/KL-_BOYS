using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsController : MonoBehaviour
{
    [SerializeField] BikeController bikeController;


    public bool IsWheelGrounded = false;
    public ParticleSystem VFX_TyreSmoke;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Ground"  )
        {
            IsWheelGrounded = true;
            if (rb.velocity.magnitude > 0)
            {
                VFX_TyreSmoke.Play();
            }
            else
            {
                VFX_TyreSmoke.Stop();
            }
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" )
        {
            IsWheelGrounded = false;
            VFX_TyreSmoke.Stop();

        }
    }
}
