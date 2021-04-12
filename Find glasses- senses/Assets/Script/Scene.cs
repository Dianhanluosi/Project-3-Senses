using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update

    public int sm = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextScene()
    {
        sm += 1;
        SceneManager.LoadScene(sm);
    }
}

