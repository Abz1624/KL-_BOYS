using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPhysics : MonoBehaviour
{
    public BuoyancyEffector2D WaterPhy_Obj;
    public float boatSpeed = 50f;

    private void Start()
    {
        WaterPhy_Obj.flowMagnitude = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wheels")
        {
            WaterPhy_Obj.flowMagnitude = boatSpeed;
        }
        else
        {
            WaterPhy_Obj.flowMagnitude = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wheels")
        {
            WaterPhy_Obj.flowMagnitude = 0;
        }
        
    }
}
