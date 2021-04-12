using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSound : MonoBehaviour
{
    public AudioSource notification;
    public bool played = false;
    public GameObject musicSwitcher;
    private MusicSwitchMazeToCat MSMTC;

    // Start is called before the first frame update
    void Start()
    {
        notification = GetComponent<AudioSource>();
        MSMTC = musicSwitcher.GetComponent<MusicSwitchMazeToCat>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(MSMTC.mad);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!played)
            {
                notification.Play();
                played = true;
                MSMTC.mad = false;

            }
        }
    }
}
