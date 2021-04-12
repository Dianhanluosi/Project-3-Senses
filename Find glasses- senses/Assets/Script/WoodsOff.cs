using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodsOff : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject trigger1;
    private WoodsOn triggr;

    void Start()
    {
        triggr = trigger1.GetComponent<WoodsOn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            if (!triggr.Wplayed)
            {
                triggr.Wplayed = true;
            }
            else if (triggr.Wplayed == true)
            {
                triggr.Wplayed = false;
            }

        }
    }
}
