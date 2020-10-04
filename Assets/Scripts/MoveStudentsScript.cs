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
        if (student.transform.position.x > 0.2f)
        {
            student.transform.position -= new Vector3(0.5f, 0, 0);
        }
    }

    public void kickOutStudent()
    {
         if (student.transform.position.x > -5.8f)
            {
                student.transform.position += new Vector3(0.5f, 0, 0);
            }
            else
            {
                Destroy(student, 0f);
            }
    }
}
