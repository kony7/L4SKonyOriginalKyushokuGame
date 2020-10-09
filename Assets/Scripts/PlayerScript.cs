using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    int score;
    int life = 5;
    int soupRequestNumber;
    int sidedishRequestNumber;
    int highScore;

    float soupAmount;
    float sidedishAmount;

    string[] amountRequestText = new string[]{"大盛り","多め","普通","少なめ","少し" };

    //bool serving = false;
    public bool beforeServing = true;
    public bool finishServing = false;

    private CreateStudentScript createStudentScript;

    public GameObject requestText;
    public GameObject ending;
    public GameObject scoreText;
    public GameObject gameObjects;
    public GameObject gameUIs;
    public GameObject createrStudent;
    public GameObject judgeText;
    public GameObject lifePointText;

    public GameObject succeseAudio;
    public GameObject unSucceseAudio;

    public GameObject soupPlate;
    public GameObject soup02;
    public GameObject soup03;
    public GameObject soup04;
    public GameObject soup05;
    public GameObject soup06;
    public GameObject soup07;
    public GameObject soup08;
    public GameObject soup09;
    public GameObject soup10;
    public GameObject soup11;

    public GameObject sidedishBowl;
    public GameObject sidedish02;
    public GameObject sidedish03;
    public GameObject sidedish04;
    public GameObject sidedish05;
    public GameObject sidedish06;
    public GameObject sidedish07;
    public GameObject sidedish08;
    public GameObject sidedish09;
    public GameObject sidedish10;

    // Start is called before the first frame update
    void Start()
    {
        createrStudent = GameObject.Find("CreaterStudent");
        createStudentScript = createrStudent.GetComponent<CreateStudentScript>();
        createStudentScript.createNewStudent();
        highScore = PlayerPrefs.GetInt("HIGHSCORE", 0);
    }

    // Update is called once per frame
    void Update()
    {
        createrStudent = GameObject.Find("CreaterStudent");
        switch (soupRequestNumber)
            {
                case 0:
                    if (soupAmount <= 7.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                        beforeServing = false;
                        soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                        finishServing = true;
                        if (soupAmount <= 7.0f && soupAmount >= 6.7f)
                        {
                            KeyUpSuccess();
                            KeyUpAfterJudgeText();
                        }
                        else
                        {
                            KeyUpLuck();
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver();
                    KeyUpAfterJudgeText();
                }
                Debug.Log(soupAmount);
                    break;


                case 1:
                    if (soupAmount <= 5.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 5.0f && soupAmount >= 4.7f)
                        {
                            KeyUpSuccess();
                            KeyUpAfterJudgeText();
                        }
                        else
                        {
                            KeyUpLuck();
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver();
                    KeyUpAfterJudgeText();
                }
                Debug.Log(soupAmount);
                break;

                case 2:
                    if (soupAmount <= 3.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 3.0f && soupAmount >= 2.7f)
                        {
                            KeyUpSuccess();
                            KeyUpAfterJudgeText();
                        }
                        else
                        {
                            KeyUpLuck();
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver();
                    KeyUpAfterJudgeText();
                }
                Debug.Log(soupAmount);
                    break;

                case 3:
                    if (soupAmount <= 2.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 2.0f && soupAmount >= 1.7f)
                        {
                            KeyUpSuccess();
                            KeyUpAfterJudgeText();
                        }
                        else
                        {
                            KeyUpLuck();
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver();
                    KeyUpAfterJudgeText();
                }
                Debug.Log(soupAmount);
                    break;

                case 4:
                    if (soupAmount <= 1.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 1.0f && soupAmount >= 0.7f)
                            {
                            KeyUpSuccess();
                            KeyUpAfterJudgeText();
                        }
                            else
                            {
                            KeyUpLuck();
                            KeyUpAfterJudgeText();
                        }
                        }
                    }
                    else
                    {
                    ServingOver();
                    KeyUpAfterJudgeText();
                }
                    Debug.Log(soupAmount);
                    break;
            }

        if(life == 0)
        {
            Invoke("goToEnding", 1.2f);
        }
    }

   
    void textRequest()
    {
        soupRequestNumber = Random.Range(0, 5);
        sidedishRequestNumber = Random.Range(0, 5);
        requestText.GetComponent<Text>().text = "スープ" + amountRequestText[soupRequestNumber] + " おかず" + amountRequestText[sidedishRequestNumber];
  
    }

    void ServingOver()
    {
        life -= 1;
        lifePointText.GetComponent<Text>().text = "LIFE：" + life;
        unSucceseAudio.GetComponent<AudioSource>().Play();
        judgeText.GetComponent<Text>().text = "多い";
    }

    void KeyUpSuccess()
    {
        score += 1;
        succeseAudio.GetComponent<AudioSource>().Play();
        judgeText.GetComponent<Text>().text = "成功";
    }

    void KeyUpLuck()
    {
        life -= 1;
        lifePointText.GetComponent<Text>().text = "LIFE：" + life;
        unSucceseAudio.GetComponent<AudioSource>().Play();
        judgeText.GetComponent<Text>().text = "少な";
    }

    void KeyUpAfterJudgeText()
    {
        Invoke("clearJudgeText", 1.1f);
        finishServing = true;
        soupAmount = 0;
        textRequest();
        createStudentScript.createNewStudent();
        beforeServing = true;
    }

    void SoupPlatePlace()
    {
       
    }

    void goToEnding()
    {
        gameObjects.SetActive(false);
        gameUIs.SetActive(false);
        scoreText.GetComponent<Text>().text = score.ToString();
        ending.SetActive(true);

        if (score > highScore)
        {
            PlayerPrefs.SetInt("HIGHSCORE", score);
            PlayerPrefs.Save();
        }
        else
        {
            
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("Start");
    }

    void clearJudgeText()
    {
        judgeText.GetComponent<Text>().text = " ";
    }
}
