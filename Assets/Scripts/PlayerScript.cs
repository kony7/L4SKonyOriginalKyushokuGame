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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(serving == false)
        {
            soupRequestNumber = Random.Range(0, 5);
            sidedishRequestNumber = Random.Range(0, 5);
            requestText.GetComponent<Text>().text = "スープ" + amountRequestText[soupRequestNumber] + " おかず" + amountRequestText[sidedishRequestNumber];
            serving = true;
        }
        else
        {
            switch (soupRequestNumber)
            {
                case 0:
                    if (soupAmount <= 25.5f)
                    {
                        if (Input.GetKey(KeyCode.Space))
                        {
                            soupAmount += 0.5f;
                        }

                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            if (soupAmount <= 20.0f && soupAmount >= 17.0f)
                            {
                                score += 1;
                            }
                            else
                            {
                                life -= 1;
                                serving = false;
                            }
                        }
                    }
                    else
                    {
                        life -= 1;
                        serving = false;
                    }
                    break;
            }
        }
    }
}
