using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 11);
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "When did O, Canada officially become the national anthem?";
                QuestionDisplay.newA = "A. 1980";
                QuestionDisplay.newB = "B. 1950";
                QuestionDisplay.newC = "C. 1920";
                QuestionDisplay.newD = "D. 1880";
                actualAnswer = "A";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Which member of the English band &quot;The xx&quot; released their solo album &quot;In Colour&quot; in 2015?";
                QuestionDisplay.newA = "A. Romy Madley Croft";
                QuestionDisplay.newB = "B. Jamie xx";
                QuestionDisplay.newC = "C. Oliver Sim";
                QuestionDisplay.newD = "D. Baria Qureshi";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Who is the leader of Team Instinct in Pok&eacute;mon Go?";
                QuestionDisplay.newA = "A. Blanche";
                QuestionDisplay.newB = "B. Spark";
                QuestionDisplay.newC = "C. Candela";
                QuestionDisplay.newD = "D. Willow";
                actualAnswer = "B";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "In Fallout: New Vegas, which one of these casinos can you not play in?";
                QuestionDisplay.newA = "A. The Tops";
                QuestionDisplay.newB = "B. Gammorah";
                QuestionDisplay.newC = "C. Ultra-Luxe";
                QuestionDisplay.newD = "D. Lucky 38";
                actualAnswer = "D";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "In what year was the movie &quot;Police Academy&quot; released?";
                QuestionDisplay.newA = "A. 1984";
                QuestionDisplay.newB = "B. 1986";
                QuestionDisplay.newC = "C. 1985";
                QuestionDisplay.newD = "D. 1983";
                actualAnswer = "A";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Kuala Lumpur is the capital of which country?";
                QuestionDisplay.newA = "A. Indonesia";
                QuestionDisplay.newB = "B. Singapore";
                QuestionDisplay.newC = "C. Malaysia";
                QuestionDisplay.newD = "D. Thailand";
                actualAnswer = "C";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "What was the name of the planned invasion of Japan towards the end of World War II?";
                QuestionDisplay.newA = "A. Operation Boarding Party";
                QuestionDisplay.newB = "B. Operation Ironclad";
                QuestionDisplay.newC = "C. Operation Aflame";
                QuestionDisplay.newD = "D. Operation Downfall";
                actualAnswer = "D";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "What colour is the circle on the Japanese flag?";
                QuestionDisplay.newA = "A. White";
                QuestionDisplay.newB = "B. Red";
                QuestionDisplay.newC = "C. Yellow";
                QuestionDisplay.newD = "D. Black";
                actualAnswer = "B";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "On a standard Monopoly board, which square is diagonally opposite &#039;Go&#039;?";
                QuestionDisplay.newA = "A. Free Parking";
                QuestionDisplay.newB = "B. Go to Jail";
                QuestionDisplay.newC = "C. Jail";
                QuestionDisplay.newD = "D. The Electric Company";
                actualAnswer = "A";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "In which British seaside town was the BBC sitcom &quot;Fawlty Towers&quot; set?";
                QuestionDisplay.newA = "A. Blackpool";
                QuestionDisplay.newB = "B. Bournemouth";
                QuestionDisplay.newC = "C. Torquay";
                QuestionDisplay.newD = "D. Great Yarmouth";
                actualAnswer = "C";
            }

            //all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
