using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCountDown : MonoBehaviour
{
    public GameObject tutorial;
    float timeLeft = 10.0f;
    public GameObject colliderA;
    private CloseTutorialAtColliderA  ca;

    // Start is called before the first frame update
    void Start()
    {
        ca = colliderA.GetComponent<CloseTutorialAtColliderA>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ca.collided == true)
        {
            tutorial.SetActive(false);
        }

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            tutorial.SetActive(false);
        }
    }
}
