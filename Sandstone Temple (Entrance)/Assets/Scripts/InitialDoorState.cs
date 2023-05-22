using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialDoorState : MonoBehaviour
{
    public CollisionCounter cCounter;

    public AudioSource audioSource;
    public AudioClip sfx; // Audio clip to play on collision

    private string targetTag = "Player"; // The tag to detect collisions with

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag) && cCounter.collisionCount == 2)
        {
            audioSource.clip = sfx;
            audioSource.Play();

            gameObject.SetActive(false);

        }
    }

}
