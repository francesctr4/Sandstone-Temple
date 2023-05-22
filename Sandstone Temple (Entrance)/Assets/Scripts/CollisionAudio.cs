using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sfx;

    public string targetTag = "Key"; // The tag to detect collisions with

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            audioSource.clip = sfx;
            audioSource.Play();
        }
        
    }
}
