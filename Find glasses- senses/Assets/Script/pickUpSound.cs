using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSound : MonoBehaviour
{
    public AudioSource notification;
    public bool played = false;

    public GameObject songmanager;
    public GameObject madcatroom;

    AudioSource SMN;
    AudioSource MCR;


    // Start is called before the first frame update
    void Start()
    {
        notification = GetComponent<AudioSource>();
        SMN = songmanager.GetComponent<AudioSource>();
        MCR = madcatroom.GetComponent<AudioSource>();
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
            if (MCR.isPlaying)
            {
                MCR.Pause();
            }
            if (!SMN.isPlaying)
            {
                SMN.Play();
            }
        }
    }
}
