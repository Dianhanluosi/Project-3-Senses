using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitchCattoMaze : MonoBehaviour
{

    //public AudioSource fun;
    //public AudioSource cat;

    public GameObject songM;
    public GameObject catM;

    public GameObject MTC;

    AudioSource main;
    AudioSource cat;
    private MusicSwitchMazeToCat matc;


    // Start is called before the first frame update
    void Start()
    {

        main = songM.GetComponent<AudioSource>();
        cat = catM.GetComponent<AudioSource>();

        matc = MTC.GetComponent<MusicSwitchMazeToCat>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (matc.catt == true)
            {
                if (!main.isPlaying)
                {
                    main.Play();
                }
                cat.Pause();
                matc.catt = false;
            }
        }


    }

}
