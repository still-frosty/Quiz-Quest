using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSportAndGame : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    
    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 30);
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Which nation hosted the FIFA World Cup in 2006?";
                QuestionDisplay.newA = "A. Russia";
                QuestionDisplay.newB = "B. Germany";
                QuestionDisplay.newC = "C. Brazil";
                QuestionDisplay.newD = "D. South Africa";
                actualAnswer = "B";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "What country hosted the 2014 Winter Olympics?";
                QuestionDisplay.newA = "A. Canada";
                QuestionDisplay.newB = "B. Russia";
                QuestionDisplay.newC = "C. Uninted States";
                QuestionDisplay.newD = "D. Germany";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Who did Steven Gerrard win the Champions League with?";
                QuestionDisplay.newA = "A. Chelsea";
                QuestionDisplay.newB = "B. Liverpool";
                QuestionDisplay.newC = "C. Man Utd";
                QuestionDisplay.newD = "D. Real Madrid";
                actualAnswer = "B";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "In bowling, what is the term used for getting three consecutive strikes?";
                QuestionDisplay.newA = "A. Turkey";
                QuestionDisplay.newB = "B. Eagle";
                QuestionDisplay.newC = "C. Birdie";
                QuestionDisplay.newD = "D. Flamingo";
                actualAnswer = "A";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Who won the UEFA Champions League in 2017?";
                QuestionDisplay.newA = "A. Atletico Madrid";
                QuestionDisplay.newB = "B. Chelsea";
                QuestionDisplay.newC = "C. Real Madrid C.F";
                QuestionDisplay.newD = "D. AS Monaco FC";
                actualAnswer = "C";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "In what sport is a the quote'shuttlecock' used?";
                QuestionDisplay.newA = "A. Badminton";
                QuestionDisplay.newB = "B. Rubgy";
                QuestionDisplay.newC = "C. Cricket";
                QuestionDisplay.newD = "D. Table Tennis";
                actualAnswer = "A";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "When was the first official international game played?";
                QuestionDisplay.newA = "A. 1863";
                QuestionDisplay.newB = "B. 1880";
                QuestionDisplay.newC = "C. 1872";
                QuestionDisplay.newD = "D. 1865";
                actualAnswer = "C";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Which sport is NOT traditionally played during the Mongolian Naadam festival?";
                QuestionDisplay.newA = "A. American Football";
                QuestionDisplay.newB = "B. Horse-Racing";
                QuestionDisplay.newC = "C. Archery";
                QuestionDisplay.newD = "D. Wrestling";
                actualAnswer = "A";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Which of the following player scored a hat-trick during their Manchester United debut?";
                QuestionDisplay.newA = "A. Robin Van Persie";
                QuestionDisplay.newB = "B. Wayne Rooney";
                QuestionDisplay.newC = "C. David Bechkam";
                QuestionDisplay.newD = "D. Christiano Ronaldo";
                actualAnswer = "B";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "What is the full name of the footballer 'Cristiano Ronaldo'?";
                QuestionDisplay.newA = "A. Cristiano Ronaldo dos Santos Aveiro";
                QuestionDisplay.newB = "B. Cristiano Ronaldo los Santos Diego";
                QuestionDisplay.newC = "C. Cristiano Armando Diego Ronaldo";
                QuestionDisplay.newD = "D. Cristiano Luis Armando Ronaldo";
                actualAnswer = "A";
            }

            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Which of the following pitchers was named National League Rookie of the Year for the 2013 season?";
                QuestionDisplay.newA = "A. Matt Harvey";
                QuestionDisplay.newB = "B. Jose Fernandez";
                QuestionDisplay.newC = "C. Jacob deGrom";
                QuestionDisplay.newD = "D. Shelby Miller";
                actualAnswer = "B";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "What was the final score of the Germany vs. Brazil 2014 FIFA World Cup match?";
                QuestionDisplay.newA = "A. 7 - 1";
                QuestionDisplay.newB = "B. 0 - 1";
                QuestionDisplay.newC = "C. 3 - 4";
                QuestionDisplay.newD = "D. 16 - 0";
                actualAnswer = "A";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Who was the top scorer of the 2014 FIFA World Cup?";
                QuestionDisplay.newA = "A. James Rodríguez";
                QuestionDisplay.newB = "B. Thomas Muller";
                QuestionDisplay.newC = "C. Neymar";
                QuestionDisplay.newD = "D. Lionel Messi";
                actualAnswer = "A";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "'Signal Iduna Park' is the stadium for which soccer team?";
                QuestionDisplay.newA = "A. Olympique Marseille";
                QuestionDisplay.newB = "B. Bolivia";
                QuestionDisplay.newC = "C. Borussia Dortmund.";
                QuestionDisplay.newD = "D. Fulham";
                actualAnswer = "C";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "What year was hockey legend Wayne Gretzky born";
                QuestionDisplay.newA = "A. 1959";
                QuestionDisplay.newB = "B. 1961";
                QuestionDisplay.newC = "C. 1965";
                QuestionDisplay.newD = "D. 1963";
                actualAnswer = "B";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Who is Manchester United top premier league goal scorer?";
                QuestionDisplay.newA = "A. Sir Bobby Charlton";
                QuestionDisplay.newB = "B. David Beckham";
                QuestionDisplay.newC = "C. Wayne Rooney";
                QuestionDisplay.newD = "D. Ryan Giggs";
                actualAnswer = "C";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "How many scoring zones are there on a conventional dart board?";
                QuestionDisplay.newA = "A. 62";
                QuestionDisplay.newB = "B. 42";
                QuestionDisplay.newC = "C. 82";
                QuestionDisplay.newD = "D. 102";
                actualAnswer = "C";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "Which country has won the most FIFA World Cups?";
                QuestionDisplay.newA = "A. Argentina";
                QuestionDisplay.newB = "B. Brazil";
                QuestionDisplay.newC = "C. Italy";
                QuestionDisplay.newD = "D. Germany";
                actualAnswer = "B";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Which dish is made from ground beef, tomatoes, and pasta in a meat sauce?";
                QuestionDisplay.newA = "A. Spaghetti Bolognese";
                QuestionDisplay.newB = "B. Beef Wellington";
                QuestionDisplay.newC = "C. Hamburger";
                QuestionDisplay.newD = "D. Lasagna";
                actualAnswer = "A";
            }
            else if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "In tennis, what is the term for a score of zero?";
                QuestionDisplay.newA = "A. Duce";
                QuestionDisplay.newB = "B. Love";
                QuestionDisplay.newC = "C. Fault";
                QuestionDisplay.newD = "D. Net";
                actualAnswer = "B";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "Who holds the record for the most home runs in a single MLB season?";
                QuestionDisplay.newA = "A. Barry Bonds";
                QuestionDisplay.newB = "B. Babe Ruth";
                QuestionDisplay.newC = "C. Mark McGwire";
                QuestionDisplay.newD = "D. Hank Aaron";
                actualAnswer = "A";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "Which country won the Rugby World Cup in 2019?";
                QuestionDisplay.newA = "A. Brazil";
                QuestionDisplay.newB = "B. South Africa";
                QuestionDisplay.newC = "C. England";
                QuestionDisplay.newD = "D. Australia";
                actualAnswer = "B";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Who won the NBA Finals MVP award in 2021?";
                QuestionDisplay.newA = "A. LeBron James";
                QuestionDisplay.newB = "B. Giannis Antetokounmpo";
                QuestionDisplay.newC = "C. Kevin Durant";
                QuestionDisplay.newD = "D. Stephen Curry";
                actualAnswer = "B";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "In which sport would you perform a ‘slam dunk’?";
                QuestionDisplay.newA = "A. Handball";
                QuestionDisplay.newB = "B. Basketball";
                QuestionDisplay.newC = "C. Tennis";
                QuestionDisplay.newD = "D. Volleyball";
                actualAnswer = "B";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "Who made the most three-point shots during the 2022-2023 NBA regular season?";
                QuestionDisplay.newA = "A. Stephen Curry";
                QuestionDisplay.newB = "B. Klay Thompson";
                QuestionDisplay.newC = "C. Damian Lillard";
                QuestionDisplay.newD = "D. Ja Morant";
                actualAnswer = "A";
            }

            else if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "Which two countries hosted the 2023 FIFA Women’s World Cup?";
                QuestionDisplay.newA = "A. England and Wales";
                QuestionDisplay.newB = "B. Australia and New Zealand";
                QuestionDisplay.newC = "C. France and Spain";
                QuestionDisplay.newD = "D. Canada and USA";
                actualAnswer = "B";
            }           
            else if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = " Who was the youngest player to score at least 50 points in a game during the 2022-23 NBA season?";
                QuestionDisplay.newA = "A. Jalen Green";
                QuestionDisplay.newB = "B. Paolo Banchero";
                QuestionDisplay.newC = "C. Anthony Edwards";
                QuestionDisplay.newD = "D. Cade Cunningham";
                actualAnswer = "C";
            }
            else if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "Which player had the most triple-doubles in the 2022-23 NBA season?";
                QuestionDisplay.newA = "A. Nikola Jokic";
                QuestionDisplay.newB = "B. Luka Dončić";
                QuestionDisplay.newC = "C. LeBron James";
                QuestionDisplay.newD = "D. Giannis Antetokounmpo";
                actualAnswer = "A";
            }

            else if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "Which player won the Golden Boot in the 2022 FIFA World Cup?";
                QuestionDisplay.newA = "A. Kylian Mbappé";
                QuestionDisplay.newB = "B. Harry Kane";
                QuestionDisplay.newC = "C. Lionel Messi";
                QuestionDisplay.newD = "D. Luka Modric";
                actualAnswer = "A";
            }
            //all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
