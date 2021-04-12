using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSound : MonoBehaviour
{
    public AudioSource notification;
    public bool played = false;

    // Start is called before the first frame update
    void Start()
    {
        notification = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!played)
            {
                notification.Play();
                played = true;
            }
        }
    }
}
