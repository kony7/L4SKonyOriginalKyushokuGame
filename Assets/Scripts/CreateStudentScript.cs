using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStudentScript : MonoBehaviour
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
    }
}
