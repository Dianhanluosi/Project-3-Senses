using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSecretWall : MonoBehaviour
{

    public Renderer sW;
    public Collider Wa;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        sW = GetComponent<Renderer>();
        Wa = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //sW.enabled = true;
            // Wa.enabled = true;
            wall.SetActive(true);

            Debug.Log("yee");

        }
    }
}
