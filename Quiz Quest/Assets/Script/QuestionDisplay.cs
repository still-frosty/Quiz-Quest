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
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;

    public static bool pleaseUpdate = false;

    void Awake()
    {
        if (pleaseUpdate == false)
        {
            pleaseUpdate = true;
            StartCoroutine(PushTextOnScreen());
        }
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<TMP_Text>().text = newQuestion;
        answerA.GetComponent<TMP_Text>().text = newA;
        answerB.GetComponent<TMP_Text>().text = newB;
        answerC.GetComponent<TMP_Text>().text = newC;
        answerD.GetComponent<TMP_Text>().text = newD;
    }
}
