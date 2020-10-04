using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStudentsScript : MonoBehaviour
{
    public GameObject student;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createNewStudent()
    {
        Instantiate(student, transform.position, transform.rotation);
        Debug.Log("今生まれた生徒はここにいます" + student.transform.position.x);
        if (student.transform.position.x > 0.2f)
        {
            student.transform.position -= new Vector3(0.5f, 0f, 0f);
        }
        else
        {
            student.transform.position = new Vector3(0.2f, -0.9f, -6.0f);
        }
    }

    public void kickOutStudent()
    {
        Debug.Log("今どけたい生徒はここにいます" + student.transform.position.x);
        if (student.transform.position.x > -5.8f)
            {
                student.transform.position += new Vector3(0.5f, 0f, 0f);
            }
            else
            {
                Destroy(student, 0f);
            }
    }
}
