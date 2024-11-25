using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionHistoryNature : MonoBehaviour
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
                QuestionDisplay.newQuestion = "What is the name of the ship that carried the Pilgrims to America in 1620?";
                QuestionDisplay.newA = "A. Mayflower";
                QuestionDisplay.newB = "B. Santa Maria";
                QuestionDisplay.newC = "C. Titanic";
                QuestionDisplay.newD = "D. Endeavour";
                actualAnswer = "A";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Which ancient wonder was located in the city of Babylon?";
                QuestionDisplay.newA = "A. The Great Pyramid";
                QuestionDisplay.newB = "B. The Hanging Gardens";
                QuestionDisplay.newC = "C. The Lighthouse of Alexandria";
                QuestionDisplay.newD = "D. The Colossus of Rhodes";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Which bird is known as the national bird of the United States?";
                QuestionDisplay.newA = "A. Bald Eagle";
                QuestionDisplay.newB = "B. Golden Eagle";
                QuestionDisplay.newC = "C. Peregrine Falcon";
                QuestionDisplay.newD = "D. Snowy Owl";
                actualAnswer = "A";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "What year did World War I begin?";
                QuestionDisplay.newA = "A. 1912";
                QuestionDisplay.newB = "B. 1914";
                QuestionDisplay.newC = "C. 1918";
                QuestionDisplay.newD = "D. 1920";
                actualAnswer = "B";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Which African desert is known as the largest hot desert in the world?";
                QuestionDisplay.newA = "A. Kalahari Desert";
                QuestionDisplay.newB = "B. Namib Desert";
                QuestionDisplay.newC = "C. Sahara Desert";
                QuestionDisplay.newD = "D. Atacama Desert";
                actualAnswer = "C";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Who was the first emperor of Rome?";
                QuestionDisplay.newA = "A. Julius Caesar";
                QuestionDisplay.newB = "B. Augustus Caesar";
                QuestionDisplay.newC = "C. Nero";
                QuestionDisplay.newD = "D. Caligula";
                actualAnswer = "B";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "What is the tallest mountain in Africa?";
                QuestionDisplay.newA = "A. Mount Kenya";
                QuestionDisplay.newB = "B. Mount Kilimanjaro";
                QuestionDisplay.newC = "C. Mount Elgon";
                QuestionDisplay.newD = "D. Atlas Mountains";
                actualAnswer = "B";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Who discovered penicillin in 1928?";
                QuestionDisplay.newA = "A. Alexander Fleming";
                QuestionDisplay.newB = "B. Louis Pasteur";
                QuestionDisplay.newC = "C. Gregor Mendel";
                QuestionDisplay.newD = "D. Marie Curie";
                actualAnswer = "A";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Which country is home to the Amazon Rainforest?";
                QuestionDisplay.newA = "A. Peru";
                QuestionDisplay.newB = "B. Brazil";
                QuestionDisplay.newC = "C. Colombia";
                QuestionDisplay.newD = "D. Venezuela";
                actualAnswer = "B";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Which historical figure is known as the 'Father of Modern Physics'?";
                QuestionDisplay.newA = "A. Isaac Newton";
                QuestionDisplay.newB = "B. Albert Einstein";
                QuestionDisplay.newC = "C. Galileo Galilei";
                QuestionDisplay.newD = "D. Nikola Tesla";
                actualAnswer = "B";
            }
            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "What is the largest mammal on Earth?";
                QuestionDisplay.newA = "A. African Elephant";
                QuestionDisplay.newB = "B. Orca";
                QuestionDisplay.newC = "C. Blue Whale";
                QuestionDisplay.newD = "D. Giraffe";
                actualAnswer = "C";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Who was the first President of the United States?";
                QuestionDisplay.newA = "A. Abraham Lincoln";
                QuestionDisplay.newB = "B. John Adams";
                QuestionDisplay.newC = "C. George Washington";
                QuestionDisplay.newD = "D. Thomas Jefferson";
                actualAnswer = "C";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Which river is the longest in the world?";
                QuestionDisplay.newA = "A. Amazon River";
                QuestionDisplay.newB = "B. Nile River";
                QuestionDisplay.newC = "C. Yangtze River";
                QuestionDisplay.newD = "D. Mississippi River";
                actualAnswer = "B";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "Which ancient civilization built the Machu Picchu ruins?";
                QuestionDisplay.newA = "A. Aztec";
                QuestionDisplay.newB = "B. Inca";
                QuestionDisplay.newC = "C. Maya";
                QuestionDisplay.newD = "D. Olmec";
                actualAnswer = "B";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "What type of tree is shown in this image?";
                QuestionDisplay.newA = "A. Oak Tree";
                QuestionDisplay.newB = "B. Baobab Tree";
                QuestionDisplay.newC = "C. Sequoia Tree";
                QuestionDisplay.newD = "D. Coconut Tree";
                visual001.SetActive(true);
                actualAnswer = "B";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Which iconic landmark is shown in this image?";
                QuestionDisplay.newA = "A. Eiffel Tower";
                QuestionDisplay.newB = "B. Taj Mahal";
                QuestionDisplay.newC = "C. Statue of Liberty";
                QuestionDisplay.newD = "D. Big Ben";
                visual002.SetActive(true);
                actualAnswer = "C";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Which planet is known as the 'Red Planet'?";
                QuestionDisplay.newA = "A. Jupiter";
                QuestionDisplay.newB = "B. Mars";
                QuestionDisplay.newC = "C. Venus";
                QuestionDisplay.newD = "D. Saturn";
                actualAnswer = "B";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "What is the capital of Ancient Egypt known for its pyramids?";
                QuestionDisplay.newA = "A. Giza";
                QuestionDisplay.newB = "B. Luxor";
                QuestionDisplay.newC = "C. Memphis";
                QuestionDisplay.newD = "D. Cairo";
                actualAnswer = "A";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "What is the largest land carnivore?";
                QuestionDisplay.newA = "A. Grizzly Bear";
                QuestionDisplay.newB = "B. Polar Bear";
                QuestionDisplay.newC = "C. Tiger";
                QuestionDisplay.newD = "D. Lion";
                actualAnswer = "B";
            }
            else if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Who was the first human to travel into space?";
                QuestionDisplay.newA = "A. Neil Armstrong";
                QuestionDisplay.newB = "B. Yuri Gagarin";
                QuestionDisplay.newC = "C. Buzz Aldrin";
                QuestionDisplay.newD = "D. Alan Shepard";
                actualAnswer = "B";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "What is the smallest country in the world by area?";
                QuestionDisplay.newA = "A. Vatican City";
                QuestionDisplay.newB = "B. Monaco";
                QuestionDisplay.newC = "C. San Marino";
                QuestionDisplay.newD = "D. Liechtenstein";
                actualAnswer = "A";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "What is the oldest written language in history?";
                QuestionDisplay.newA = "A. Latin";
                QuestionDisplay.newB = "B. Sanskrit";
                QuestionDisplay.newC = "C. Sumerian";
                QuestionDisplay.newD = "D. Egyptian Hieroglyphics";
                actualAnswer = "C";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Which animal is shown in this image?";
                QuestionDisplay.newA = "A. Giraffe";
                QuestionDisplay.newB = "B. Tiger";
                QuestionDisplay.newC = "C. Kangaroo";
                QuestionDisplay.newD = "D. Sloth";
                visual003.SetActive(true);
                actualAnswer = "C";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "Which sea creature is known to have three hearts?";
                QuestionDisplay.newA = "A. Octopus";
                QuestionDisplay.newB = "B. Squid";
                QuestionDisplay.newC = "C. Whale Shark";
                QuestionDisplay.newD = "D. Starfish";
                actualAnswer = "A";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "What is the tallest waterfall in the world?";
                QuestionDisplay.newA = "A. Niagara Falls";
                QuestionDisplay.newB = "B. Victoria Falls";
                QuestionDisplay.newC = "C. Angel Falls";
                QuestionDisplay.newD = "D. Yosemite Falls";
                actualAnswer = "C";
            }
            else if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "Which famous battle was fought in 1066?";
                QuestionDisplay.newA = "A. Battle of Hastings";
                QuestionDisplay.newB = "B. Battle of Waterloo";
                QuestionDisplay.newC = "C. Battle of Agincourt";
                QuestionDisplay.newD = "D. Battle of Thermopylae";
                actualAnswer = "A";
            }
            else if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = "Which lake is the deepest in the world?";
                QuestionDisplay.newA = "A. Lake Baikal";
                QuestionDisplay.newB = "B. Lake Superior";
                QuestionDisplay.newC = "C. Lake Victoria";
                QuestionDisplay.newD = "D. Lake Tanganyika";
                actualAnswer = "A";
            }
            else if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "Who painted the famous artwork 'The Last Supper'?";
                QuestionDisplay.newA = "A. Leonardo da Vinci";
                QuestionDisplay.newB = "B. Michelangelo";
                QuestionDisplay.newC = "C. Raphael";
                QuestionDisplay.newD = "D. Donatello";
                actualAnswer = "A";
            }
            else if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "What is the term for a volcano that has not erupted in a long time but may erupt again?";
                QuestionDisplay.newA = "A. Dormant";
                QuestionDisplay.newB = "B. Extinct";
                QuestionDisplay.newC = "C. Active";
                QuestionDisplay.newD = "D. Submerged";
                actualAnswer = "A";
            }
            //all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
