using UnityEngine;

public class SFX_Bike : MonoBehaviour
{
    // AudioSource component that will play the engine sound
    public AudioSource engineAudioSource;

    // The minimum and maximum pitch values for the engine sound
    public float minPitch = 1f;
    public float maxPitch = 2f;

    // The minimum and maximum volume values for the engine sound
    public float minVolume = 0.5f;
    public float maxVolume = 1f;

    // The minimum and maximum speed values for the bike
    public float minSpeed = 0f;
    public float maxSpeed = 100f;

    // The 2D rigidbody component of the bike
    public Rigidbody2D rb;
    
    void Update()
    {
        // Get the current speed of the bike by calculating the magnitude of the 2D velocity
        float currentSpeed = rb.velocity.magnitude;

        // Calculate the pitch and volume values based on the current speed of the bike
        float pitch = Mathf.Lerp(minPitch, maxPitch, (currentSpeed - minSpeed) / (maxSpeed - minSpeed));
        float volume = Mathf.Lerp(minVolume, maxVolume, (currentSpeed - minSpeed) / (maxSpeed - minSpeed));

        // Set the pitch and volume of the engine audio source
        engineAudioSource.pitch = pitch;
        engineAudioSource.volume = volume;

        // Play the engine sound if it's not already playing
        if (!engineAudioSource.isPlaying)
        {
            engineAudioSource.Play();
        }
    }
}
