using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesPickedUp : MonoBehaviour
{

    AudioSource pickUp;

    // Start is called before the first frame update
    void Start()
    {
        pickUp = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            pickUp.Play();
        }
    }

}
