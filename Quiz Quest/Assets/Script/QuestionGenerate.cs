using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public GameObject visual001;
    public GameObject visual002;
    public GameObject visual003;

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 26);
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
                QuestionDisplay.newQuestion = "Which member of the English band 'The xx' released their solo album 'In Colour' in 2015?";
                QuestionDisplay.newA = "A. Romy Madley Croft";
                QuestionDisplay.newB = "B. Jamie xx";
                QuestionDisplay.newC = "C. Oliver Sim";
                QuestionDisplay.newD = "D. Baria Qureshi";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Who is the leader of Team Instinct in Pokemon Go?";
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
                QuestionDisplay.newQuestion = "In what year was the movie 'Police Academy' released?";
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
                QuestionDisplay.newQuestion = "On the standard Monopoly board, free parking is diagonally opposite of 'go'";
                QuestionDisplay.newA = "A. Free Parking";
                QuestionDisplay.newB = "B. Go to Jail";
                QuestionDisplay.newC = "C. Jail";
                QuestionDisplay.newD = "D. The Electric Company";
                actualAnswer = "A";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "When was the original Star Wars: Battlefront II released?";
                QuestionDisplay.newA = "A. November 21, 2006";
                QuestionDisplay.newB = "B. September 9, 2007";
                QuestionDisplay.newC = "C. October 31, 2005";
                QuestionDisplay.newD = "D. December 18, 2004";
                actualAnswer = "C";
            }
            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "What country flag is this?";
                QuestionDisplay.newA = "A. China";
                QuestionDisplay.newB = "B. Spain";
                QuestionDisplay.newC = "C. South Sudan";
                QuestionDisplay.newD = "D. Germany";
                visual001.SetActive(true);
                actualAnswer = "B";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "What country flag is this?";
                QuestionDisplay.newA = "A. United States of America";
                QuestionDisplay.newB = "B. Tokyo";
                QuestionDisplay.newC = "C. Egpty";
                QuestionDisplay.newD = "D. Russia";
                visual002.SetActive(true);
                actualAnswer = "A";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "What country flag is this?";
                QuestionDisplay.newA = "A. China";
                QuestionDisplay.newB = "B. Ghana";
                QuestionDisplay.newC = "C. South Sudan";
                QuestionDisplay.newD = "D. Nigeria";
                visual003.SetActive(true);
                actualAnswer = "D";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "What was the first Super Mario game ever released in North America for the 3DS?";
                QuestionDisplay.newA = "A. Super Mario 3D Land";
                QuestionDisplay.newB = "B. Super Mario Maker";
                QuestionDisplay.newC = "C. New Super Mario Bros. 2";
                QuestionDisplay.newD = "D. Mario Kart 7";
                actualAnswer = "A";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Which of these songs by artist Eminem contain the lyric 'Nice to meet you. Hi, my name is... I forgot my name!'?";
                QuestionDisplay.newA = "A. Square Dance";
                QuestionDisplay.newB = "B. Kim";
                QuestionDisplay.newC = "C. Without Me";
                QuestionDisplay.newD = "D. Rain Man";
                actualAnswer = "D";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Who was the inspiration for Cuthbert Calculus in the Tintin series?";
                QuestionDisplay.newA = "A. Will Morris";
                QuestionDisplay.newB = "B. Auguste Picard";
                QuestionDisplay.newC = "C. Jacques Piccard";
                QuestionDisplay.newD = "D. J. Cecil Maby";
                actualAnswer = "B";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Which team was the 2015-2016 NBA Champions?";
                QuestionDisplay.newA = "A. Golden State Warriors";
                QuestionDisplay.newB = "B. Toronto Raptors";
                QuestionDisplay.newC = "C. Cleveland Cavaliers";
                QuestionDisplay.newD = "D. Oklahoma City Thunders";
                actualAnswer = "C";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "When someone is inexperienced they are said to be what color?";
                QuestionDisplay.newA = "A. Green";
                QuestionDisplay.newB = "B. Purple";
                QuestionDisplay.newC = "C. Red";
                QuestionDisplay.newD = "D. Black";
                actualAnswer = "A";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Greenland is a part of which kingdom?";
                QuestionDisplay.newA = "A. Sweden";
                QuestionDisplay.newB = "B. Norway";
                QuestionDisplay.newC = "C. Denmark";
                QuestionDisplay.newD = "D. United Kingdom";
                actualAnswer = "C";
            }
            else if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Who is the youngest person to recieve a Nobel Prize?";
                QuestionDisplay.newA = "A. Lawrence Bragg";
                QuestionDisplay.newB = "B. SMalala Yousafzai";
                QuestionDisplay.newC = "C. Werner Heisenberg";
                QuestionDisplay.newD = "D. Yasser Arafat";
                actualAnswer = "B";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "When was Hubba Bubba first introduced?";
                QuestionDisplay.newA = "A. 1880";
                QuestionDisplay.newB = "B. 1979";
                QuestionDisplay.newC = "C. 2000";
                QuestionDisplay.newD = "D. 1990";
                actualAnswer = "B";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "The AHL affiliate team of the Boston Bruins is named what?";
                QuestionDisplay.newA = "A. Providence Bruins";
                QuestionDisplay.newB = "B. New Haven Bruins";
                QuestionDisplay.newC = "C. Cambridge Bruins";
                QuestionDisplay.newD = "D. Hartford Bruins";
                actualAnswer = "A";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Which member of the Velvet Room is not a playable character in Persona 4 Arena Ultimax?";
                QuestionDisplay.newA = "A. Marie";
                QuestionDisplay.newB = "B. Margaret";
                QuestionDisplay.newC = "C. Elizabeth";
                QuestionDisplay.newD = "D. Theodore";
                actualAnswer = "D";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "In a 1994 CBS interview, Microsoft co-founder Bill Gates performed what unusual trick on camera?";
                QuestionDisplay.newA = "A. Jumping backwards over a desk";
                QuestionDisplay.newB = "B. Standing on his head";
                QuestionDisplay.newC = "C. Jumping over an office chair";
                QuestionDisplay.newD = "D. Typing on a keyboard during a handstand";
                actualAnswer = "C";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "Before 2016, in which other year did Donald Trump run for President?";
                QuestionDisplay.newA = "A. 2000";
                QuestionDisplay.newB = "B. 1988";
                QuestionDisplay.newC = "C. 1993";
                QuestionDisplay.newD = "D. 2008";
                actualAnswer = "A";
            }

            //all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
