using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SousaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ToLeft();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ToStart();
        }
    }

    public void ToLeft()
    {
        SceneManager.LoadScene("Rule");
    }

    public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
