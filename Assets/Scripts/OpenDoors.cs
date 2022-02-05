using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    [SerializeField] GameObject door1;
    [SerializeField] GameObject door2;
    [SerializeField] GameObject door3;
    [SerializeField] GameObject door4;
    [SerializeField] GameObject door5;
    [SerializeField] GameObject door6;
    [SerializeField] GameObject door7;
    [SerializeField] GameObject door8;
    [SerializeField] GameObject door9;
    [SerializeField] GameObject door10;
    [SerializeField] GameObject door11;
    [SerializeField] GameObject door12;
    [SerializeField] GameObject door13;

    private int questionNumber = 0;
    private bool pressed1 = false;
    private bool pressed2 = false;
    private bool pressed3 = false;
    private bool pressed4 = false;

    // Start is called before the first frame update
    void Start()
    {
        questionNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Keypad1) || Input.GetKey(KeyCode.Alpha1))
        {
            pressed1 = true;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
        }

        else if(Input.GetKeyUp(KeyCode.Keypad2) || Input.GetKeyUp(KeyCode.Alpha2))
        {
            pressed1 = false;
            pressed2 = true;
            pressed3 = false;
            pressed4 = false;
        }

        else if(Input.GetKeyUp(KeyCode.Keypad3) || Input.GetKeyUp(KeyCode.Alpha3))
        {
            pressed1 = false;
            pressed2 = false;
            pressed3 = true;
            pressed4 = false;
        }

        else if(Input.GetKeyUp(KeyCode.Keypad4) || Input.GetKeyUp(KeyCode.Alpha4))
        {
            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = true;
        }

        if(questionNumber == 1)
        {
            if(pressed2)
            {
                door1.SetActive(false);
                questionNumber++;
            }

            else if(pressed1 || pressed3 || pressed4)
            {
                Debug.Log("Wrong answer, try again");
            }
        }
    }
}
