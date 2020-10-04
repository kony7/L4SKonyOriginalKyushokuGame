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
                    if (soupAmount <= 55.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 50.0f && soupAmount >= 47.0f)
                            {
                                score += 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else if (soupAmount < 0.1f)
                    {
                        life -= 1;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }

                    Debug.Log(soupAmount);
                    break;


                case 1:
                    if (soupAmount <= 45.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 40.0f && soupAmount >= 37.0f)
                            {
                                score += 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else if (soupAmount < 0.1f)
                    {
                        life -= 1;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }
                    Debug.Log(soupAmount);
                break;

                case 2:
                    if (soupAmount <= 35.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 30.0f && soupAmount >= 27.0f)
                            {
                                score += 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else if (soupAmount < 0.1f)
                    {
                        life -= 1;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }
                    Debug.Log(soupAmount);
                    break;

                case 3:
                    if (soupAmount <= 25.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 20.0f && soupAmount >= 17.0f)
                            {
                                score += 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else if (soupAmount < 0.1f)
                    {
                        life -= 1;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }
                    Debug.Log(soupAmount);
                    break;

                case 4:
                    if (soupAmount <= 15.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.1f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 10.0f && soupAmount >= 5.0f)
                            {
                                score += 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                            else
                            {
                                life -= 1;
                            createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                            textRequest();
                            createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                        }
                        }
                    }
                    else if(soupAmount < 0.1f)
                    {
                        life -= 1;
                    createrStudent.GetComponent<MoveStudentsScript>().kickOutStudent();
                    textRequest();
                    createrStudent.GetComponent<MoveStudentsScript>().createNewStudent();
                }
                    Debug.Log(soupAmount);
                    break;
            }

        if(life == 0)
        {
            gameObjects.SetActive(false);
            gameUIs.SetActive(false);
            scoreText.GetComponent<Text>().text = score.ToString();
            ending.SetActive(true);
        }
    }

   
    void textRequest()
    {
        soupRequestNumber = Random.Range(0, 5);
        sidedishRequestNumber = Random.Range(0, 5);
        requestText.GetComponent<Text>().text = "スープ" + amountRequestText[soupRequestNumber] + " おかず" + amountRequestText[sidedishRequestNumber];
  
    }

    //void kickoutStudent()
    //{
    //    if (tooutStudent.transform.position.x > -6.5f)
    //    {
    //        tooutStudent.transform.position += new Vector3(0.5f, 0, 0);
    //    }
    //    else
    //    {
    //        Destroy(tooutStudent,0f);
    //    }
    //}

    //void createNewStudent()
    //{
    //    Instantiate(toinStudent, new Vector3(5.3f, -18.042f, -38.0f), transform.rotation);
    //    if (toinStudent.transform.position.x > 0)
    //    {
    //        toinStudent.transform.position -= new Vector3(0.5f, 0, 0);
    //    }
    //}

    public void restart()
    {
        SceneManager.LoadScene("Start");
    }
}
