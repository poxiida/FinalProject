using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play3DSound : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // This method will be called when the object collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the AudioSource is not null and play the sound
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}