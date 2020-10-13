using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ToRight();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ToStart();
        }
    }

    public void ToRight()
    {
        SceneManager.LoadScene("Sousa");
    }

    public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
