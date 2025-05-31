using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play3DSoundOnTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
