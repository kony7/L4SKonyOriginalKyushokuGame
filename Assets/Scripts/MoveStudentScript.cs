﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStudentScript : MonoBehaviour
{
    public GameObject gameManager;
    PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        playerScript = gameManager.GetComponent<PlayerScript>();

        
    }

    // Update is called once per frame
    void Update()
    {
        bool beforeServingSignal = playerScript.beforeServing;
        bool finishServingSignal = playerScript.finishServing;

        if (beforeServingSignal == true)
        {
            if (transform.position.x > 0.2f)
            {
                transform.position -= new Vector3(0.5f, 0f, 0f);
            }
            else
            {

            }
        }
        else
        {

        }

        if(finishServingSignal == true)
        {
            if (transform.position.x > -5.8f)
            {
                transform.position -= new Vector3(0.5f, 0f, 0f);
            }
            else if(transform.position.x < -5.8f)
            {
                Destroy(this, 0f);
            }
            else
            {

            }
        }
        else
        {

        }
    }
}
