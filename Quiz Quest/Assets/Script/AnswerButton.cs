using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public AudioSource correctFX;
    public AudioSource wrongFX;

    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;
    public GameObject bestDisplay;

    public GameObject visual001;
    public GameObject visual002;
    public GameObject visual003;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz", 0);
        bestDisplay.GetComponent<TMP_Text>().text = "Best: " + bestScore;
    }

    void Update()
    {
        currentScore.GetComponent<TMP_Text>().text = "Score: " + scoreValue;
    }

    private bool IsCorrectAnswer(string correctAnswer)
    {
        return QuestionGenerate.actualAnswer == correctAnswer ||
        QuestionEnt.actualAnswer == correctAnswer ||
        QuestionFoodCulture.actualAnswer == correctAnswer ||
        QuestionHistoryNature.actualAnswer == correctAnswer ||
        QuestionsScienceAndTech.actualAnswer == correctAnswer ||
        QuestionSportAndGame.actualAnswer == correctAnswer;
    }

    public void AnswerA()
    {
        // if (QuestionGenerate.actualAnswer == "A" || QuestionEnt.actualAnswer == "A")
        if (IsCorrectAnswer("A"))
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue -= 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        // if (QuestionGenerate.actualAnswer == "B" || QuestionEnt.actualAnswer == "B")
        if (IsCorrectAnswer("B"))
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue -= 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        // if (QuestionGenerate.actualAnswer == "C" || QuestionEnt.actualAnswer == "C")
        if (IsCorrectAnswer("C"))
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue -= 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        // if (QuestionGenerate.actualAnswer == "D" || QuestionEnt.actualAnswer == "D")
        if (IsCorrectAnswer("D"))
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue -= 1;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<TMP_Text>().text = "Best: " + scoreValue;
        }
        yield return new WaitForSeconds(1.5f);

        visual001.SetActive(false);
        visual002.SetActive(false);
        visual003.SetActive(false);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerate.displayingQuestion = false;
        QuestionEnt.displayingQuestion = false;
        QuestionFoodCulture.displayingQuestion = false;
        QuestionHistoryNature.displayingQuestion = false;
        QuestionsScienceAndTech.displayingQuestion = false;
        QuestionSportAndGame.displayingQuestion = false;
    }
}
