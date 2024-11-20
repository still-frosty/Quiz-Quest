using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            QuestionDisplay.newQuestion = "How much will you be paid to kill a mouse?";
            QuestionDisplay.newA = "A. $10";
            QuestionDisplay.newB = "B. $20";
            QuestionDisplay.newC = "C. $30";
            QuestionDisplay.newD = "D. $40";
            actualAnswer = "A";
        }
    }
}
