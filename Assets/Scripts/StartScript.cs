using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{

    public GameObject highScoreText;
    int intHighScore;


    // Start is called before the first frame update
    void Start()
    {
        intHighScore = PlayerPrefs.GetInt("HIGHSCORE", 0);
        highScoreText.GetComponent<Text>().text = intHighScore.ToString();

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Rule");
        }
    }

}
