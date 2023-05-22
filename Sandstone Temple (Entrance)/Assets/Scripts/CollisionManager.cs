using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public string targetTag = "Key"; // The tag to detect collisions with

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
