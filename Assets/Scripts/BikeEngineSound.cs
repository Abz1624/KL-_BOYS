using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeEngineSound : MonoBehaviour
{
    // Initialize the audio source for the engine sound
    public AudioSource engineSound;

    // Initialize the audio clips for the low, medium, and high engine sounds
    public AudioClip lowEngineSound;
    public AudioClip mediumEngineSound;
    public AudioClip highEngineSound;

    // Initialize the current speed of the bike
    public float currentSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        // Get the current speed of the bike
        currentSpeed = GetComponent<Rigidbody2D>().velocity.magnitude;

        // Play the appropriate engine sound based on the current speed of the bike
        if (currentSpeed < 5)
        {
            engineSound.clip = lowEngineSound;
            if (!engineSound.isPlaying)
            {
                engineSound.Play();
            }
        }
        else if (currentSpeed >= 7 && currentSpeed < 9)
        {
            engineSound.clip = mediumEngineSound;
            if (!engineSound.isPlaying)
            {
                engineSound.Play();
            }
        }
        else if (currentSpeed >= 9)
        {
            engineSound.clip = highEngineSound;
            if (!engineSound.isPlaying)
            {
                engineSound.Play();
            }
        }
    }
}

