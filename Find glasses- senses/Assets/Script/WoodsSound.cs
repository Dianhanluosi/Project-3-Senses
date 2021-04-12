using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodsSound : MonoBehaviour
{

    public GameObject woodsonscript;
    private WoodsOn triggrr;

    public AudioSource woodsong;

    // Start is called before the first frame update
    void Start()
    {
        triggrr = woodsonscript.GetComponent<WoodsOn>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!triggrr.Wplayed)
        {
            woodsong.Stop();
        }
        else if (triggrr.Wplayed == true)
        {
            woodsong.Play();
        }
    }
}
