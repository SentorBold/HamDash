using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainHealth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().GainHealt();
            Destroy(gameObject)
                ;
        }
    }
}
