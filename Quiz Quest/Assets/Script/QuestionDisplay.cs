using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    void Start()
    {
        screenQuestion.GetComponent<TMP_Text>().text = "How much will you be paid to kill a mouse?";
        answerA.GetComponent<TMP_Text>().text = "A. $10";
        answerB.GetComponent<TMP_Text>().text = "B. $20";
        answerC.GetComponent<TMP_Text>().text = "C. $30";
        answerD.GetComponent<TMP_Text>().text = "D. $40";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
