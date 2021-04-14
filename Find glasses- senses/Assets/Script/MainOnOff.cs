using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject songManage;
    AudioSource main;

    void Start()
    {
        main = songManage.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!main.isPlaying)
            {
                main.Play();
            }
            else if (main.isPlaying)
            {
                main.Pause();
            }
        }
    }
}
