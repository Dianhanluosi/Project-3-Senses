using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playMeow : MonoBehaviour
{
    bool ending = false;
    float timeLeft = 5.0f;
    public AudioSource audioSource;

    private bool played = false;

    private void Update()
    {
        if (ending == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                endScene();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!ending)
        {
            ending = true;
        }
        if (!played) { 
            if (other.gameObject.tag == "Player")
            {
                audioSource.Play();
                played = true;

            } }


    }

    void endScene()
    {
        SceneManager.LoadScene(2);
    }
}
