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
    public bool endding = false;

    bool sidedishjudge;

    private CreateStudentScript createStudentScript;

    public GameObject requestText;
    public GameObject ending;
    public GameObject scoreText;
    public GameObject gameUIs;
    public GameObject createrStudent;
    public GameObject judgeTextsoup;
    public GameObject judgeTextsidedish;
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

        if(sidedishAmount == 0)
        {
            SideDishPlatePlace();
        }
        else if(sidedishAmount == 1)
        {
            SideDishPlus02();
        }
        else if (sidedishAmount == 2)
        {
            SideDishPlus03();
        }
        else if (sidedishAmount == 3)
        {
            SideDishPlus04();
        }
        else if (sidedishAmount == 4)
        {
            SideDishPlus05();
        }
        else if (sidedishAmount == 5)
        {
            SideDishPlus06();
        }
        else if (sidedishAmount == 6)
        {
            SideDishPlus07();
        }
        else if (sidedishAmount == 7)
        {
            SideDishPlus08();
        }
        else if (sidedishAmount == 8)
        {
            SideDishPlus09();
        }
        else if (sidedishAmount == 9)
        {
            SideDishPlus10();
        }
        

        switch (sidedishRequestNumber)
        {
            case 0:
                if(sidedishAmount < 10)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        sidedishAmount += 1;
                    }

                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        sidedishAmount -= 1;
                    }

                    if (Input.GetKeyUp(KeyCode.Space))
                    {
                        if (sidedishAmount == 9)
                        {
                            KeyUpSuccess(false);
                            sidedishjudge = false;
                        }
                        else if(sidedishAmount < 9)
                        {
                            KeyUpLuck(false);
                            sidedishjudge = true;
                        }
                        else
                        {
                            ServingOver(false);
                            sidedishjudge = true;
                        }
                    }
                   
                }
                else
                {
                    
                }
                break;

            case 1:
                if (sidedishAmount < 10)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        sidedishAmount += 1;
                    }

                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        sidedishAmount -= 1;
                    }

                    if (Input.GetKeyUp(KeyCode.Space))
                    {
                        if (sidedishAmount == 7)
                        {
                            KeyUpSuccess(false);
                            sidedishjudge = false;
                        }
                        else if(sidedishAmount < 7)
                        {
                            KeyUpLuck(false);
                            sidedishjudge = true;
                        }
                        else
                        {
                            ServingOver(false);
                            sidedishjudge = true;
                        }
                    }
                }
                else
                {

                }
                break;

            case 2:
                if (sidedishAmount < 10)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        sidedishAmount += 1;
                    }

                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        sidedishAmount -= 1;
                    }

                    if (Input.GetKeyUp(KeyCode.Space))
                    {
                        if (sidedishAmount == 5)
                        {
                            KeyUpSuccess(false);
                            sidedishjudge = false;
                        }
                        else if(sidedishAmount < 5)
                        {
                            KeyUpLuck(false);
                            sidedishjudge = true;
                        }
                        else
                        {
                            ServingOver(false);
                            sidedishjudge = true;
                        }
                    }
                }
                else
                {

                }
                break;

            case 3:
                if (sidedishAmount < 10)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        sidedishAmount += 1;
                    }

                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        sidedishAmount -= 1;
                    }

                    if (Input.GetKeyUp(KeyCode.Space))
                    {
                        if (sidedishAmount == 3)
                        {
                            KeyUpSuccess(false);
                            sidedishjudge = false;
                        }
                        else if(sidedishAmount < 3)
                        {
                            KeyUpLuck(false);
                            sidedishjudge = true;
                        }
                        else
                        {
                            ServingOver(false);
                            sidedishjudge = true;
                        }
                    }
                }
                else
                {

                }
                break;

            case 4:
                if (sidedishAmount < 10)
                {
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        sidedishAmount += 1;
                    }

                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        sidedishAmount -= 1;
                    }

                    if (Input.GetKeyUp(KeyCode.Space))
                    {
                        if (sidedishAmount == 1)
                        {
                            KeyUpSuccess(false);
                            sidedishjudge = false;
                        }
                        else if(sidedishAmount < 1)
                        {
                            KeyUpLuck(false);
                            sidedishjudge = true;
                        }
                        else
                        {
                            ServingOver(false);
                            sidedishjudge = true;
                        }
                    }
                }
                else
                {
                    
                }
                break;
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
                        if (soupAmount >= 4.1f && soupAmount <= 4.6f)
                        {
                            KeyUpSuccess(true);
                            KeyUpAfterJudgeText();
                        }
                        else if(soupAmount < 4.1f)
                        {
                            KeyUpLuck(true);
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver(true);
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
                         if (soupAmount >= 3.1f && soupAmount <= 3.6f)
                        {
                            KeyUpSuccess(true);
                            KeyUpAfterJudgeText();
                        }
                        else if (soupAmount < 3.1f)
                        {
                            KeyUpLuck(true);
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver(true);
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
                            if (soupAmount >= 2.1f && soupAmount <= 2.6f)
                        {
                            KeyUpSuccess(true);
                            KeyUpAfterJudgeText();
                        }
                        else if (soupAmount < 2.1f)
                        {
                            KeyUpLuck(true);
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver(true);
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
                            if (soupAmount >= 1.1f && soupAmount <= 1.6f)
                        {
                            KeyUpSuccess(true);
                            KeyUpAfterJudgeText();
                        }
                        else if (soupAmount < 1.1f)
                        {
                            KeyUpLuck(true);
                            KeyUpAfterJudgeText();
                        }
                    }
                }
                else
                {
                    ServingOver(true);
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
                            if (soupAmount >= 0.1f && soupAmount <= 0.6f)
                            {
                            KeyUpSuccess(true);
                            KeyUpAfterJudgeText();
                        }
                        else if (soupAmount < 0.1f)
                        {
                            KeyUpLuck(true);
                            KeyUpAfterJudgeText();
                        }
                        }
                    }
                    else
                    {
                    ServingOver(true);
                    KeyUpAfterJudgeText();
                }
                    Debug.Log(soupAmount);
                    break;
            }

        if(life <= 0)
        {
            Invoke("goToEnding", 0.6f);
        }
    }

   
    void textRequest()
    {
        soupRequestNumber = Random.Range(0, 5);
        sidedishRequestNumber = Random.Range(0, 5);
        requestText.GetComponent<Text>().text = "スープ" + amountRequestText[soupRequestNumber] + " おかず" + amountRequestText[sidedishRequestNumber];
  
    }

    void ServingOver(bool souptrue)
    {
        lifePointText.GetComponent<Text>().text = "LIFE：" + life;
        unSucceseAudio.GetComponent<AudioSource>().Play();

        if (souptrue == true)
        {
            if(sidedishjudge == true)
            {
                life -= 1;
            }
            else
            {

            }

            judgeTextsoup.GetComponent<Text>().text = "多い";
        }
        else
        {
            judgeTextsidedish.GetComponent<Text>().text = "多い";
        }
    }

    void KeyUpSuccess(bool souptrue)
    {
        succeseAudio.GetComponent<AudioSource>().Play();
        
        if (souptrue == true)
        {
            if (sidedishjudge == false)
            {
                score += 1;
            }
            judgeTextsoup.GetComponent<Text>().text = "成功";
        }
        else
        {
            judgeTextsidedish.GetComponent<Text>().text = "成功";
        }
    }

    void KeyUpLuck(bool souptrue)
    {
        lifePointText.GetComponent<Text>().text = "LIFE：" + life;
        unSucceseAudio.GetComponent<AudioSource>().Play();

        if (souptrue == true)
        {
            if (sidedishjudge == true)
            {
                life -= 1;
            }

            judgeTextsoup.GetComponent<Text>().text = "少な";
        }
        else
        {
            judgeTextsidedish.GetComponent<Text>().text = "少な";
        }
    }

    void KeyUpAfterJudgeText()
    {
        Invoke("clearJudgeText", 1.1f);
        finishServing = true;
        soupAmount = 0;
        sidedishAmount = 0;
        textRequest();
        if (life > 0)
        {
            createStudentScript.createNewStudent();
        }
        else
        {

        }
        beforeServing = true;
    }

    void SideDishPlatePlace()
    {
        sidedishBowl.SetActive(true);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus02()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(true);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus03()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(true);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus04()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(true);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus05()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(true);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus06()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(true);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus07()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(true);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus08()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(true);
        sidedish09.SetActive(false);
        sidedish10.SetActive(false);
    }

    void SideDishPlus09()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(true);
        sidedish10.SetActive(false);
    }

    void SideDishPlus10()
    {
        sidedishBowl.SetActive(false);
        sidedish02.SetActive(false);
        sidedish03.SetActive(false);
        sidedish04.SetActive(false);
        sidedish05.SetActive(false);
        sidedish06.SetActive(false);
        sidedish07.SetActive(false);
        sidedish08.SetActive(false);
        sidedish09.SetActive(false);
        sidedish10.SetActive(true);
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
        endding = true;
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
        judgeTextsoup.GetComponent<Text>().text = " ";
        judgeTextsidedish.GetComponent<Text>().text = " ";
    }
}
