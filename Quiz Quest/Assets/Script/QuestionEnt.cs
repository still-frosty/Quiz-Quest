using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionEnt : MonoBehaviour
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
                QuestionDisplay.newQuestion = "Brendan Fraser starred in the following movies, except which one?";
                QuestionDisplay.newA = "A. Titanic";
                QuestionDisplay.newB = "B. Monkeybone";
                QuestionDisplay.newC = "C. Encino Man";
                QuestionDisplay.newD = "D. Mrs. Winterbourne";
                actualAnswer = "A";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "In Finding Nemo, what was the name of Nemo's mom?";
                QuestionDisplay.newA = "A. Sandy";
                QuestionDisplay.newB = "B. Coral";
                QuestionDisplay.newC = "C. Pearl";
                QuestionDisplay.newD = "D. Shelly";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Which former Star Trek actor directed Three Men and a Baby (1987)?";
                QuestionDisplay.newA = "A. William Shatner";
                QuestionDisplay.newB = "B. Leonard Nimoy";
                QuestionDisplay.newC = "C. George Takei";
                QuestionDisplay.newD = "D. James Doohan";
                actualAnswer = "B";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Which of the following James Bond villains is not affiliated with the SPECTRE organization?";
                QuestionDisplay.newA = "A. Dr. Julius No";
                QuestionDisplay.newB = "B. Rosa Klebb";
                QuestionDisplay.newC = "C. Emilio Largo";
                QuestionDisplay.newD = "D. Auric Goldfinger";
                actualAnswer = "D";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Which town is the setting for the Disney movie The Love Bug (1968)?";
                QuestionDisplay.newA = "A. San Francisco";
                QuestionDisplay.newB = "B. Los Angeles";
                QuestionDisplay.newC = "C. Sacramento";
                QuestionDisplay.newD = "D. San Jose";
                actualAnswer = "A";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Who won the Grammy for Album of the Year in 2023?";
                QuestionDisplay.newA = "A. Harry Styles";
                QuestionDisplay.newB = "B. Beyoncé";
                QuestionDisplay.newC = "C. Adele";
                QuestionDisplay.newD = "D. Taylor Swift";
                actualAnswer = "A";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Which video game series features characters like Master Chief and Cortana?";
                QuestionDisplay.newA = "A. Halo";
                QuestionDisplay.newB = "B. Call of Duty";
                QuestionDisplay.newC = "C. Destiny";
                QuestionDisplay.newD = "D. Battlefield";
                actualAnswer = "A";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "What year was Netflix founded?";
                QuestionDisplay.newA = "A. 1994";
                QuestionDisplay.newB = "B. 2001";
                QuestionDisplay.newC = "C. 1997";
                QuestionDisplay.newD = "D. 2000";
                actualAnswer = "C";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Who directed the movie 'Inception'?";
                QuestionDisplay.newA = "A. Steven Spielberg";
                QuestionDisplay.newB = "B. Christopher Nolan";
                QuestionDisplay.newC = "C. James Cameron";
                QuestionDisplay.newD = "D. Quentin Tarantino";
                actualAnswer = "B";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "What is the name of the AI assistant in the Iron Man movies?";
                QuestionDisplay.newA = "A. J.A.R.V.I.S.";
                QuestionDisplay.newB = "B. A.L.F.R.E.D.";
                QuestionDisplay.newC = "C. S.A.M.";
                QuestionDisplay.newD = "D. K.A.R.E.N.";
                actualAnswer = "A";
            }
            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Who sang the hit song 'Blinding Lights'?";
                QuestionDisplay.newA = "A. Drake";
                QuestionDisplay.newB = "B. The Weeknd";
                QuestionDisplay.newC = "C. Justin Bieber";
                QuestionDisplay.newD = "D. Bruno Mars";
                actualAnswer = "B";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Which character in 'Friends' is known for saying 'We were on a break!'?";
                QuestionDisplay.newB = "A. Chandler";
                QuestionDisplay.newC = "B. Joey";
                QuestionDisplay.newA = "C. Ross";
                QuestionDisplay.newD = "D. Rachel";
                actualAnswer = "C";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Which actor played Jack Dawson in the movie Titanic?";
                QuestionDisplay.newA = "A. Brad Pitt";
                QuestionDisplay.newC = "B. Matt Damon";
                QuestionDisplay.newD = "C. Johnny Depp";
                QuestionDisplay.newB = "D. Leonardo DiCaprio";
                actualAnswer = "B";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "Which video game features the fictional location of Raccoon City?";
                QuestionDisplay.newA = "A. Silent Hill";
                QuestionDisplay.newB = "B. Resident Evil";
                QuestionDisplay.newC = "C. The Last of Us";
                QuestionDisplay.newD = "D. Dead Space";
                actualAnswer = "B";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Which music artist holds the record for the most Grammy Awards won in a single night?";
                QuestionDisplay.newA = "A. Adele";
                QuestionDisplay.newB = "B. Beyoncé";
                QuestionDisplay.newC = "C. Michael Jackson";
                QuestionDisplay.newD = "D. Taylor Swift";
                actualAnswer = "C";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Which character's logo is this?";
                QuestionDisplay.newA = "A. Batman";
                QuestionDisplay.newB = "B. Superman";
                QuestionDisplay.newC = "C. Iron man";
                QuestionDisplay.newD = "D. Spider-Man";
                visual001.SetActive(true);
                actualAnswer = "A";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "What is the name of the wizarding bank in the Harry Potter series?";
                QuestionDisplay.newA = "A. Ollivanders";
                QuestionDisplay.newB = "B. Gringotts";
                QuestionDisplay.newC = "C. Diagon Alley";
                QuestionDisplay.newD = "D. Hogsmeade Bank";
                actualAnswer = "B";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "Which fictional language is spoken by the Elves in *The Lord of the Rings*?";
                QuestionDisplay.newA = "A. Klingon";
                QuestionDisplay.newB = "B. Sindarin";
                QuestionDisplay.newC = "C. Valyrian";
                QuestionDisplay.newD = "D. Dothraki";
                actualAnswer = "B";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "What is the name of the ship in the movie *Pirates of the Caribbean*?";
                QuestionDisplay.newA = "A. The Jolly Roger";
                QuestionDisplay.newB = "B. The Flying Dutchman";
                QuestionDisplay.newC = "C. The Black Pearl";
                QuestionDisplay.newD = "D. The Queen Anne’s Revenge";
                actualAnswer = "C";
            }
            else if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Which movie features this iconic poster?";
                QuestionDisplay.newA = "A. Jaws";
                QuestionDisplay.newB = "B. The Godfather";
                QuestionDisplay.newC = "C. Titanic";
                QuestionDisplay.newD = "D. The Matrix";
                visual002.SetActive(true);
                actualAnswer = "D";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "Which popular TV show is set in the fictional town of Hawkins, Indiana?";
                QuestionDisplay.newA = "A. The X-Files";
                QuestionDisplay.newB = "B. Stranger Things";
                QuestionDisplay.newC = "C. Twin Peaks";
                QuestionDisplay.newD = "D. Breaking Bad";
                actualAnswer = "B";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "In which Disney movie does the character Maui appear?";
                QuestionDisplay.newA = "A. Moana";
                QuestionDisplay.newB = "B. Frozen";
                QuestionDisplay.newC = "C. Tangled";
                QuestionDisplay.newD = "D. Encanto";
                actualAnswer = "A";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Which painting is famously housed in the Louvre Museum in Paris?";
                QuestionDisplay.newA = "A. The Starry Night";
                QuestionDisplay.newB = "B. Mona Lisa";
                QuestionDisplay.newC = "C. The Scream";
                QuestionDisplay.newD = "D. Girl with a Pearl Earring";
                actualAnswer = "B";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "Which famous musician is known as the 'King of Pop'?";
                QuestionDisplay.newA = "A. Elvis Presley";
                QuestionDisplay.newB = "B. Michael Jackson";
                QuestionDisplay.newC = "C. Prince";
                QuestionDisplay.newD = "D. Stevie Wonder";
                actualAnswer = "B";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "What is the name of Beyoncé’s alter ego introduced during her *Sasha Fierce* era?";
                QuestionDisplay.newA = "A. Queen Bey";
                QuestionDisplay.newB = "B. Sasha Fierce";
                QuestionDisplay.newC = "C. Yoncé";
                QuestionDisplay.newD = "D. Honey Bee";
                actualAnswer = "B";
            }
            else if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "Which movie does this iconic scene belong to?";
                QuestionDisplay.newA = "A. Inception";
                QuestionDisplay.newB = "B. Titanic";
                QuestionDisplay.newC = "C. The Great Gatsby";
                QuestionDisplay.newD = "D. The Wol of Wall Street";
                visual003.SetActive(true);
                actualAnswer = "C";
            }
            else if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = "Which K-pop group released the song *Dynamite*?";
                QuestionDisplay.newA = "A. Blackpink";
                QuestionDisplay.newB = "B. BTS";
                QuestionDisplay.newC = "C. EXO";
                QuestionDisplay.newD = "D. TWICE";
                actualAnswer = "B";
            }
            else if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "Which Netflix series is based on the life of British royalty?";
                QuestionDisplay.newA = "A. *The Crown*";
                QuestionDisplay.newB = "B. *Downton Abbey*";
                QuestionDisplay.newC = "C. *Bridgerton*";
                QuestionDisplay.newD = "D. *Victoria*";
                actualAnswer = "A";
            }
            else if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "What is the name of the fictional country in *Black Panther*?";
                QuestionDisplay.newA = "A. Zamunda";
                QuestionDisplay.newB = "B. Wakanda";
                QuestionDisplay.newC = "C. Latveria";
                QuestionDisplay.newD = "D. Genovia";
                actualAnswer = "B";
            }
            // else if (questionNumber == 30)
            // {
            //     QuestionDisplay.newQuestion = "Which singer released the album *25* in 2015?";
            //     QuestionDisplay.newA = "A. Taylor Swift";
            //     QuestionDisplay.newB = "B. Adele";
            //     QuestionDisplay.newC = "C. Lady Gaga";
            //     QuestionDisplay.newD = "D. Rihanna";
            //     actualAnswer = "B";
            // }

            //all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
