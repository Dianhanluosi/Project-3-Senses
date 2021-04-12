using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitchMazeToCat : MonoBehaviour
{

    //public AudioSource fun;
    //public AudioSource cat;

    public bool mad = false;
    public GameObject player;
    private SeeClear seeClear;

    // Start is called before the first frame update
    void Start()
    {
        seeClear = player.GetComponent<SeeClear>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            if (!seeClear.seeC)
            {
                if (!mad)
                {
                    mad = true;
                }
                else
                {

                }
            }
            else { }
        }
    }

}
