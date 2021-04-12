using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeSureSeeClear : MonoBehaviour
{

    public GameObject player;
    private SeeClear seeClear;
    PortalTeleporter script;

    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<PortalTeleporter>();
        seeClear = player.GetComponent<SeeClear>();
    }

    // Update is called once per frame
    void Update()
    {
        if (seeClear.seeC == true)
        {
            script.enabled = true;
        }
    }
}
