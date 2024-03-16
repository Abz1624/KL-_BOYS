using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : MonoBehaviour
{
    public ParticleSystem VFX_CrowFlying;
    public GameObject CrowSitting;
    private void Start()
    {
        CrowSitting.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bike")
        {
            StartCoroutine(PlayCrow());
        }
    }

    IEnumerator PlayCrow()
    {
        VFX_CrowFlying.Play();
        CrowSitting.SetActive(false);
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
