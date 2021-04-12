using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource aud;
    public int sm = 0;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextScene()
    {
        aud.Play();
        sm += 1;
        SceneManager.LoadScene(sm);
    }
}

