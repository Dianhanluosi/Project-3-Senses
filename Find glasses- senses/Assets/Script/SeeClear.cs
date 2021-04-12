using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeClear : MonoBehaviour
{

    public bool seeC = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Glasses"))
        {
            seeC = true;
        }
    }
}
