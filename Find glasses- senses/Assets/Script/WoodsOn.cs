using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodsOn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject woodsSound;
    public bool Wplayed = false;

    private void Update()
    {
        if (!Wplayed)
        {
            woodsSound.SetActive(false);
        }
        else if (Wplayed == true)
        {
            woodsSound.SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!Wplayed)
            {
                Wplayed = true;
            }
            else if (Wplayed == true)
            {
                Wplayed = false;
            }
        }
    }

}
