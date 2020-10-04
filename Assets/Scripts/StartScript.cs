using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{

    public GameObject highScoreText;
    int intHighScore;
    string stringHighScore;


    // Start is called before the first frame update
    void Start()
    {
        intHighScore = PlayerPrefs.GetInt("HIGHSCORE", 0);
        stringHighScore = intHighScore.ToString();
        Debug.Log(intHighScore + "は数字");
        Debug.Log(stringHighScore + "は文字");
        highScoreText.GetComponent<Text>().text = stringHighScore;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void start()
    {
        SceneManager.LoadScene("Main");
    }
}
