using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadCatOnOff : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject madCatS;
    AudioSource madc;
    void Start()
    {
        madc = madCatS.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!madc.isPlaying)
            {
                madc.Play();
            }
            else if (madc.isPlaying)
            {
                madc.Pause();
            }
        }
    }
}
