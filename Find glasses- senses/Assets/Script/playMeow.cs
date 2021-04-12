using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMeow : MonoBehaviour
{
    public AudioSource audioSource;

    private bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!played) { 
            if (other.gameObject.tag == "Player")
            {
                audioSource.Play();
                played = true;
            } }
    }
}
