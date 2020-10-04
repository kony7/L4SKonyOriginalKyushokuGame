﻿using System.Collections;
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

    float soupAmount;
    float sidedishAmount;

    string[] amountRequestText = new string[]{"大盛り","多め","普通","少なめ","少し" };

    bool serving = false;

    public GameObject requestText;
    public GameObject ending;
    public GameObject scoreText;
    public GameObject gameObjects;
    public GameObject gameUIs;
    public GameObject tooutStudent;
    public GameObject toinStudent;
    public GameObject createrStudent;
    public GameObject judgeText;
    public GameObject lifePointText;

    // Start is called before the first frame update
    void Start()
    {
        createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
    }

    // Update is called once per frame
    void Update()
    {
            switch (soupRequestNumber)
            {
                case 0:
                    if (soupAmount <= 18.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 18.0f && soupAmount >= 17.7f)
                            {
                                score += 1;
                            judgeText.GetComponent<Text>().text = "ナイス";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                            judgeText.GetComponent<Text>().text = "少な！";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else
                    {
                        life -= 1;
                    lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                    judgeText.GetComponent<Text>().text = "多い！";
                    Invoke("clearJudgeText", 1.1f);
                    soupAmount = 0;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }

                    Debug.Log(soupAmount);
                    break;


                case 1:
                    if (soupAmount <= 15.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 15.0f && soupAmount >= 14.7f)
                            {
                                score += 1;
                            judgeText.GetComponent<Text>().text = "ナイス";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                            judgeText.GetComponent<Text>().text = "少な！";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else 
                    {
                        life -= 1;
                    lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                    judgeText.GetComponent<Text>().text = "多い！";
                    Invoke("clearJudgeText", 1.1f);
                    soupAmount = 0;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }
                    Debug.Log(soupAmount);
                break;

                case 2:
                    if (soupAmount <= 10.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 10.0f && soupAmount >= 9.7f)
                            {
                                score += 1;
                            judgeText.GetComponent<Text>().text = "ナイス";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                            judgeText.GetComponent<Text>().text = "少な！";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else
                    {
                        life -= 1;
                    lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                    judgeText.GetComponent<Text>().text = "多い！";
                    Invoke("clearJudgeText", 1.1f);
                    soupAmount = 0;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }
                    Debug.Log(soupAmount);
                    break;

                case 3:
                    if (soupAmount <= 6.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 6.0f && soupAmount >= 5.7f)
                            {
                                score += 1;
                            judgeText.GetComponent<Text>().text = "ナイス";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                            judgeText.GetComponent<Text>().text = "少な！";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else
                    {
                        life -= 1;
                    lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                    judgeText.GetComponent<Text>().text = "多い！";
                    Invoke("clearJudgeText", 1.1f);
                    soupAmount = 0;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }
                    Debug.Log(soupAmount);
                    break;

                case 4:
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
                                score += 1;
                            judgeText.GetComponent<Text>().text = "ナイス";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                            judgeText.GetComponent<Text>().text = "少な！";
                            Invoke("clearJudgeText", 1.1f);
                            soupAmount = 0;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else
                    {
                        life -= 1;
                    lifePointText.GetComponent<Text>().text = "LIFE：" + life;
                    judgeText.GetComponent<Text>().text = "多い！";
                    Invoke("clearJudgeText", 1.1f);

                    soupAmount = 0;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
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

    void goToEnding()
    {
        gameObjects.SetActive(false);
        gameUIs.SetActive(false);
        scoreText.GetComponent<Text>().text = score.ToString();
        ending.SetActive(true);
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
