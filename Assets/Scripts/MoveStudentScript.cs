using System.Collections;
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
            Debug.Log("今ビフォアがTrue");
            if (transform.position.x > 0.4f)
            {
                transform.position -= new Vector3(0.3f, 0f, 0f);
            }
            else
            {

            }
        }
        else
        {
            Debug.Log("今ビフォアがFalse");
        }

        if(finishServingSignal == true)
        {
            Debug.Log("今フィニッシュがTrue");
            if (transform.position.x > -5.8f)
            {
                transform.position -= new Vector3(0.3f, 0f, 0f);
            }
            else if(transform.position.x < -5.8f)
            {
                playerScript.finishServing = false;
                Destroy(this.gameObject, 0f);
            }
            else
            {

            }
        }
        else
        {
            Debug.Log("今フィニッシュがFalse");
        }
    }
}
