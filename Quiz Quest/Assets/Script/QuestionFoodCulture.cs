using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionFoodCulture : MonoBehaviour
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
            questionNumber = Random.Range(1, 30);
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Which country is famous for inventing sushi?";
                QuestionDisplay.newA = "A. China";
                QuestionDisplay.newB = "B. Japan";
                QuestionDisplay.newC = "C. Korea";
                QuestionDisplay.newD = "D. Thailand";
                actualAnswer = "B";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "What is the main ingredient in traditional Italian risotto?";
                QuestionDisplay.newA = "A. Pasta";
                QuestionDisplay.newB = "B. Rice";
                QuestionDisplay.newC = "C. Bread";
                QuestionDisplay.newD = "D. Potatoes";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "In which country did the croissant originate?";
                QuestionDisplay.newA = "A. France";
                QuestionDisplay.newB = "B. Austria";
                QuestionDisplay.newC = "C. Germany";
                QuestionDisplay.newD = "D. Italy";
                actualAnswer = "B";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Which spice is known as the most expensive in the world?";
                QuestionDisplay.newA = "A. Saffron";
                QuestionDisplay.newB = "B. Cinnamon";
                QuestionDisplay.newC = "C. Vanilla";
                QuestionDisplay.newD = "D. Cardamom";
                actualAnswer = "A";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Which country is the largest producer of coffee in the world?";
                QuestionDisplay.newA = "A. Colombia";
                QuestionDisplay.newB = "B. Vietnam";
                QuestionDisplay.newC = "C. Brazil";
                QuestionDisplay.newD = "D. Ethiopia";
                actualAnswer = "C";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Which country is known for its traditional dish 'paella'?";
                QuestionDisplay.newA = "A. Spain";
                QuestionDisplay.newB = "B. Portugal";
                QuestionDisplay.newC = "C. Italy";
                QuestionDisplay.newD = "D. Greece";
                actualAnswer = "A";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Kimchi is a staple side dish in which country's cuisine?";
                QuestionDisplay.newA = "A. Japan";
                QuestionDisplay.newB = "B. China";
                QuestionDisplay.newC = "C. Korea";
                QuestionDisplay.newD = "D. Thailand";
                actualAnswer = "C";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Which type of pasta is shaped like little rice grains?";
                QuestionDisplay.newA = "A. Penne";
                QuestionDisplay.newB = "B. Orzo";
                QuestionDisplay.newC = "C. Fusilli";
                QuestionDisplay.newD = "D. Rigatoni";
                actualAnswer = "B";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "What is the national dish of Mexico?";
                QuestionDisplay.newA = "A. Tacos";
                QuestionDisplay.newB = "B. Mole";
                QuestionDisplay.newC = "C. Enchiladas";
                QuestionDisplay.newD = "D. Tamales";
                actualAnswer = "B";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Which fruit is known as the 'king of fruits'?";
                QuestionDisplay.newA = "A. Durian";
                QuestionDisplay.newB = "B. Mango";
                QuestionDisplay.newC = "C. Pineapple";
                QuestionDisplay.newD = "D. Banana";
                actualAnswer = "A";
            }

            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Which country is known for the dish 'poutine'?";
                QuestionDisplay.newA = "A. France";
                QuestionDisplay.newB = "B. Canada";
                QuestionDisplay.newC = "C. United States";
                QuestionDisplay.newD = "D. Belgium";
                actualAnswer = "B";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Which country is the origin of the spicy dish 'vindaloo'?";
                QuestionDisplay.newA = "A. India";
                QuestionDisplay.newB = "B. Bangladesh";
                QuestionDisplay.newC = "C. Pakistan";
                QuestionDisplay.newD = "D. Sri Lanka";
                actualAnswer = "A";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "The Eiffel Tower is located in which city?";
                QuestionDisplay.newA = "A. Paris";
                QuestionDisplay.newB = "B. London";
                QuestionDisplay.newC = "C. Berlin";
                QuestionDisplay.newD = "D. Rome";
                actualAnswer = "A";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "In which country can you find the ancient ruins of Machu Picchu?";
                QuestionDisplay.newA = "A. Peru";
                QuestionDisplay.newB = "B. Bolivia";
                QuestionDisplay.newC = "C. Ecuador";
                QuestionDisplay.newD = "D. Chile";
                actualAnswer = "A";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Which country is known for the dish 'sauerbraten' (pot roast)?";
                QuestionDisplay.newA = "A. Austria";
                QuestionDisplay.newB = "B. Germany";
                QuestionDisplay.newC = "C. Switzerland";
                QuestionDisplay.newD = "D. Denmark";
                actualAnswer = "B";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Which fruit is traditionally used to make guacamole?";
                QuestionDisplay.newA = "A. Mango";
                QuestionDisplay.newB = "B. Tomato";
                QuestionDisplay.newC = "C. Avocado";
                QuestionDisplay.newD = "D. Papaya";
                actualAnswer = "C";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Which of these countries is famous for producing fine wine?";
                QuestionDisplay.newA = "A. Australia";
                QuestionDisplay.newB = "B. Argentina";
                QuestionDisplay.newC = "C. France";
                QuestionDisplay.newD = "D. India";
                actualAnswer = "C";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "In which country was the sandwich invented?";
                QuestionDisplay.newA = "A. United States";
                QuestionDisplay.newB = "B. England";
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
                QuestionDisplay.newQuestion = "Which country is known for the famous dessert 'baklava'?";
                QuestionDisplay.newA = "A. Greece";
                QuestionDisplay.newB = "B. Turkey";
                QuestionDisplay.newC = "C. Lebanon";
                QuestionDisplay.newD = "D. Egypt";
                actualAnswer = "B";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "Which country's traditional dish is shown in this image?";
                QuestionDisplay.newA = "A. Japan";
                QuestionDisplay.newB = "B. Italy";
                QuestionDisplay.newC = "C. India";
                QuestionDisplay.newD = "D. Mexico";
                visual001.SetActive(true); // Image of Sushi (Japan)
                actualAnswer = "A";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "Which culture is known for this colorful festival?";
                QuestionDisplay.newA = "A. Brazil";
                QuestionDisplay.newB = "B. India";
                QuestionDisplay.newC = "C. Spain";
                QuestionDisplay.newD = "D. China";
                visual002.SetActive(true); // image of holi festival(India)
                actualAnswer = "B";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Which Nigerian cultural festival is shown in this image?";
                QuestionDisplay.newA = "A. Argungun Festival";
                QuestionDisplay.newB = "B. Eyo Festival";
                QuestionDisplay.newC = "C. Durbar Festival";
                QuestionDisplay.newD = "D. Osun-Osogbo Festival";
                visual003.SetActive(true); // Image of the Eyo Festival (for example)
                actualAnswer = "B";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "Which Nigerian dish is made from fermented cassava and usually served with soup?";
                QuestionDisplay.newA = "A. Eba";
                QuestionDisplay.newB = "B. Fufu";
                QuestionDisplay.newC = "C. Akara";
                QuestionDisplay.newD = "D. Pounded Yam";
                actualAnswer = "B";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "Which of these Nigerian languages is predominantly spoken in Lagos?";
                QuestionDisplay.newA = "A. Yoruba";
                QuestionDisplay.newB = "B. Hausa";
                QuestionDisplay.newC = "C. Igbo";
                QuestionDisplay.newD = "D. Kanuri";
                actualAnswer = "A";
            }

            else if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "What is the traditional Nigerian attire worn by men in the southwestern region?";
                QuestionDisplay.newA = "A. Dashiki";
                QuestionDisplay.newB = "B. Agbada";
                QuestionDisplay.newC = "C. Kilt";
                QuestionDisplay.newD = "D. Boubou";
                actualAnswer = "B";
            }           
            else if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = "Which Nigerian musician is known for popularizing Afrobeat worldwide?";
                QuestionDisplay.newA = "A. Burna Boy";
                QuestionDisplay.newB = "B. Wizkid";
                QuestionDisplay.newC = "C. Fela Kuti";
                QuestionDisplay.newD = "D. Davido";
                actualAnswer = "C";
            }
            else if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "In Japanese culture, what is the traditional tea ceremony called?";
                QuestionDisplay.newA = "A. Chanoyu";
                QuestionDisplay.newB = "B. Sado";
                QuestionDisplay.newC = "C. Kintsugi";
                QuestionDisplay.newD = "D. Ikebana";
                actualAnswer = "A";
            }

            else if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "Which Brazilian festival is known for its extravagant parades, music, and dancing?";
                QuestionDisplay.newA = "A. Carnival";
                QuestionDisplay.newB = "B. Oktoberfest";
                QuestionDisplay.newC = "C. Dia de los Muertos";
                QuestionDisplay.newD = "D. Songkran";
                actualAnswer = "A";
            }
            //all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
