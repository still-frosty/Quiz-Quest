using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    public GameObject answerAbackBlue; // Blue is waiting
    public GameObject answerAbackGreen; // Green is correct
    public GameObject answerAbackRed; // Red is wrong

    public GameObject answerBbackBlue; // Blue is waiting
    public GameObject answerBbackGreen; // Green is correct
    public GameObject answerBbackRed; // Red is wrong

    public GameObject answerCbackBlue; // Blue is waiting
    public GameObject answerCbackGreen; // Green is correct
    public GameObject answerCbackRed; // Red is wrong

    public GameObject answerDbackBlue; // Blue is waiting
    public GameObject answerDbackGreen; // Green is correct
    public GameObject answerDbackRed; // Red is wrong

    public void AnswerA()
    {
        if (QuestionGenerate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
        }
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
        }
    }

    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
        }
    }

    public void AnswerD()
    {
        if (QuestionGenerate.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
        }
    }
}
