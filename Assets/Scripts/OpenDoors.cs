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
    [SerializeField] AudioSource openDoor;
    [SerializeField] AudioSource wrongAnswer;

    private int qNum = 1;

    public int numWrong = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Keypad1) || Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("Pressed 1!");
            checkAnswer(1);
        }

        if(Input.GetKeyUp(KeyCode.Keypad2) || Input.GetKeyUp(KeyCode.Alpha2))
        {
            Debug.Log("Pressed 2!");
            checkAnswer(2);
        }

        if(Input.GetKeyUp(KeyCode.Keypad3) || Input.GetKeyUp(KeyCode.Alpha3))
        {
            Debug.Log("Pressed 3!");
            checkAnswer(3);
        }

        if(Input.GetKeyUp(KeyCode.Keypad4) || Input.GetKeyUp(KeyCode.Alpha4))
        {
            Debug.Log("Pressed 4!");
            checkAnswer(4);
        }
    }

    private void checkAnswer(int answer)
    {
        if(qNum == 1)
        {
            if(answer == 1)
            {
                Debug.Log("correct!");
                door1.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if(qNum == 2)
        {
            if(answer == 1)
            {
                Debug.Log("correct!");
                door2.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 3)
        {
            if (answer == 3)
            {
                Debug.Log("correct!");
                door3.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 4)
        {
            if (answer == 2)
            {
                Debug.Log("correct!");
                door4.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 5)
        {
            if (answer == 4)
            {
                Debug.Log("correct!");
                door5.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 6)
        {
            if (answer == 2)
            {
                Debug.Log("correct!");
                door6.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 7)
        {
            if (answer == 4)
            {
                Debug.Log("correct!");
                door7.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 8)
        {
            if (answer == 2)
            {
                Debug.Log("correct!");
                door8.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 9)
        {
            if (answer == 4)
            {
                Debug.Log("correct!");
                door9.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 10)
        {
            if (answer == 4)
            {
                Debug.Log("correct!");
                door10.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }

        else if (qNum == 11)
        {
            if (answer == 3)
            {
                Debug.Log("correct!");
                door11.SetActive(false);
                openDoor.Play();
                qNum++;
            }

            else
            {
                Debug.Log("I'm sorry, that's the wrong answer!");
                numWrong++;
                wrongAnswer.Play();
            }
        }
    }
}
