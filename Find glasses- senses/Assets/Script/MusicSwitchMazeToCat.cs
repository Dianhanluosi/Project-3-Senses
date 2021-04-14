using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitchMazeToCat : MonoBehaviour
{

    //public AudioSource fun;
    //public AudioSource cat;


    public GameObject songM;
    public GameObject catM;

    AudioSource main;
    AudioSource cat;

    public bool catt = false;


    // Start is called before the first frame update
    void Start()
    {

        main = songM.GetComponent<AudioSource>();
        cat = catM.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!catt)
            {
                main.Pause();
                cat.Play();
                catt = true;
            }
        }


    }

}
