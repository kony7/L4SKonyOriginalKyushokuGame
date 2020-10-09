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

        if(soupAmount == 0)
        {
            SoupPlatePlace();
        }else if(soupAmount < 0.6)
        {
            SoupPlus02();
        }
        else if (soupAmount < 1.0)
        {
            SoupPlus03();
        }
        else if (soupAmount < 1.5)
        {
            SoupPlus04();
        }
        else if (soupAmount < 2.0)
        {
            SoupPlus05();
        }
        else if (soupAmount < 2.5)
        {
            SoupPlus06();
        }
        else if (soupAmount < 3.0)
        {
            SoupPlus07();
        }
        else if (soupAmount < 3.5)
        {
            SoupPlus08();
        }
        else if (soupAmount < 4.0)
        {
            SoupPlus09();
        }
        else if (soupAmount < 4.5)
        {
            SoupPlus10();
        }
        else if (soupAmount < 5.0)
        {
            SoupPlus11();
        }

        switch (soupRequestNumber)
            {
                case 0:
                    if (soupAmount < 5.0f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                        beforeServing = false;
                        soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                        finishServing = true;
                        if (soupAmount <= 4.1f && soupAmount >= 4.4f)
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
                    if (soupAmount < 4.0f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 3.1f && soupAmount >= 3.4f)
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
                    if (soupAmount < 3.0f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 2.1f && soupAmount >= 2.4f)
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
                    if (soupAmount < 2.0f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 1.1f && soupAmount >= 1.4f)
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
                    if (soupAmount < 1.0f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 0.1f && soupAmount >= 0.4f)
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
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(true);
    }

    void SoupPlus02()
    {
        soup02.SetActive(true);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus03()
    {
        soup02.SetActive(false);
        soup03.SetActive(true);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus04()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(true);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus05()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(true);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus06()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(true);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus07()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(true);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus08()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(true);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus09()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(true);
        soup10.SetActive(false);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus10()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(true);
        soup11.SetActive(false);
        soupPlate.SetActive(false);
    }

    void SoupPlus11()
    {
        soup02.SetActive(false);
        soup03.SetActive(false);
        soup04.SetActive(false);
        soup05.SetActive(false);
        soup06.SetActive(false);
        soup07.SetActive(false);
        soup08.SetActive(false);
        soup09.SetActive(false);
        soup10.SetActive(false);
        soup11.SetActive(true);
        soupPlate.SetActive(false);
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
