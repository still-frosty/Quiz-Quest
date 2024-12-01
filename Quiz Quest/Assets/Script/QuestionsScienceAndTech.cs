using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsScienceAndTech : MonoBehaviour
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
                QuestionDisplay.newQuestion = "What is the name of this Scientist?";
                QuestionDisplay.newA = "A. Sir Isaac Newton";
                QuestionDisplay.newB = "B. Niels Bohr";
                QuestionDisplay.newC = "C. Albert Einstein";
                QuestionDisplay.newD = "D. Enrico Fermi";
                visual003.SetActive(true);
                actualAnswer = "A";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "The Tibia is found in which part of the body?";
                QuestionDisplay.newA = "A. Arm";
                QuestionDisplay.newB = "B. Leg";
                QuestionDisplay.newC = "C. Hand";
                QuestionDisplay.newD = "D. Head";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "What is the official name of the star located closest to the North Celestial Pole?";
                QuestionDisplay.newA = "A. Polaris";
                QuestionDisplay.newB = "B. Eridanus";
                QuestionDisplay.newC = "C. Gamma Cephei";
                QuestionDisplay.newD = "D. Iota Cephei";
                actualAnswer = "A";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "How many chromosomes are in your body cells?";
                QuestionDisplay.newA = "A. 25";
                QuestionDisplay.newB = "B. 23";
                QuestionDisplay.newC = "C. 24";
                QuestionDisplay.newD = "D. 21";
                actualAnswer = "B";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Human cells typically have how many copies of each gene?";
                QuestionDisplay.newA = "A. 5";
                QuestionDisplay.newB = "B. 3";
                QuestionDisplay.newC = "C. 2";
                QuestionDisplay.newD = "D. 4";
                actualAnswer = "C";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "What is the process by which Plants Make their won food?";
                QuestionDisplay.newA = "A. Respiration";
                QuestionDisplay.newB = "B. Photosynthesis";
                QuestionDisplay.newC = "C. Digestion";
                QuestionDisplay.newD = "D. Fermentation";
                actualAnswer = "B";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "What is water's chemical formula?";
                QuestionDisplay.newA = "A. SO4";
                QuestionDisplay.newB = "B. H2O";
                QuestionDisplay.newC = "C. NaCl";
                QuestionDisplay.newD = "D. CO2";
                actualAnswer = "B";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "What is the boiling point of water at sea level?";
                QuestionDisplay.newA = "A. 100°C";
                QuestionDisplay.newB = "B. 0°C";
                QuestionDisplay.newC = "C. 50°C";
                QuestionDisplay.newD = "D. 212°C";
                actualAnswer = "A";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Which is the smallest planet in our solar system?";
                QuestionDisplay.newA = "A. Mars";
                QuestionDisplay.newB = "B. Mercury";
                QuestionDisplay.newC = "C. Pluto";
                QuestionDisplay.newD = "D. Venus";
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
                QuestionDisplay.newQuestion = "What gas do plants absorb from the atmosphere?";
                QuestionDisplay.newA = "A. Nitrogen";
                QuestionDisplay.newB = "B. Oxygen";
                QuestionDisplay.newC = "C. Carbon dioxide";
                QuestionDisplay.newD = "D. Methane";
                actualAnswer = "C";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "What is the center of an atom called?";
                QuestionDisplay.newA = "A. Electron";
                QuestionDisplay.newB = "B. Proton";
                QuestionDisplay.newC = "C. Nucleus";
                QuestionDisplay.newD = "D. Neutron";
                actualAnswer = "C";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "What does DNA stand for?";
                QuestionDisplay.newA = "A. Digital Network Array";
                QuestionDisplay.newB = "B. Deoxyribonucleic Acid";
                QuestionDisplay.newC = "C. Data Neural Analysis";
                QuestionDisplay.newD = "D. Dynamic Neural Algorithm";
                actualAnswer = "B";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "What is the name of the first artificial satellite sent into space?";
                QuestionDisplay.newA = "A. Explorer 1";
                QuestionDisplay.newB = "B. Sputnik";
                QuestionDisplay.newC = "C. Apollo 11";
                QuestionDisplay.newD = "D. Luna 2";
                actualAnswer = "B";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "What is the symbol for gold on the periodic table?";
                QuestionDisplay.newA = "A. Ag";
                QuestionDisplay.newB = "B. Au";
                QuestionDisplay.newC = "C. Pb";
                QuestionDisplay.newD = "D. Hg";
                actualAnswer = "B";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "What is the powerhouse of the cell?";
                QuestionDisplay.newA = "A. Ribosome";
                QuestionDisplay.newB = "B. Nucleus";
                QuestionDisplay.newC = "C. Mitochondria";
                QuestionDisplay.newD = "D. Golgi apparatus";
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
                QuestionDisplay.newQuestion = "Which planet is the closest to the Sun?";
                QuestionDisplay.newA = "A. Mercury";
                QuestionDisplay.newB = "B. Venus";
                QuestionDisplay.newC = "C. Earth";
                QuestionDisplay.newD = "D. Mars";
                actualAnswer = "A";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "What is the main component of the Sun?";
                QuestionDisplay.newA = "A. Carbon";
                QuestionDisplay.newB = "B. Hydrogen";
                QuestionDisplay.newC = "C. Oxygen";
                QuestionDisplay.newD = "D. Helium";
                visual001.SetActive(true);
                actualAnswer = "B";
            }
            else if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Which gas is commonly known as laughing gas?";
                QuestionDisplay.newA = "A. Carbon Dioxide";
                QuestionDisplay.newB = "B. Nitrous Oxide";
                QuestionDisplay.newC = "C. Helium";
                QuestionDisplay.newD = "D. Nitrogen";
                actualAnswer = "B";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "Which planet is known for its prominent ring system?";
                QuestionDisplay.newA = "A. Saturn";
                QuestionDisplay.newB = "B. Jupiter";
                QuestionDisplay.newC = "C. Uranus";
                QuestionDisplay.newD = "D. Neptune";
                actualAnswer = "A";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "How many planets are in the Solar System?";
                QuestionDisplay.newA = "A. Ten";
                QuestionDisplay.newB = "B. Nine";
                QuestionDisplay.newC = "C. Eight";
                QuestionDisplay.newD = "D. Seven";
                actualAnswer = "C";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Which organ in the human body is responsible for filtering blood?";
                QuestionDisplay.newA = "A. Heart";
                QuestionDisplay.newB = "B. Liver";
                QuestionDisplay.newC = "C. Kidney";
                QuestionDisplay.newD = "D. Lungs";
                actualAnswer = "C";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "What is the primary gas found in Earth's atmosphere";
                QuestionDisplay.newA = "A. Nitrogen";
                QuestionDisplay.newB = "B. Oxygen";
                QuestionDisplay.newC = "C. Argon";
                QuestionDisplay.newD = "D. Carbon Dioxide";
                actualAnswer = "A";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "What is the chemical symbol for potassium?";
                QuestionDisplay.newA = "A. Pt";
                QuestionDisplay.newB = "B. Po";
                QuestionDisplay.newC = "C. K";
                QuestionDisplay.newD = "D. P";
                actualAnswer = "C";
            }
            else if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "What do we call the molten rock that comes out of a volcano?";
                QuestionDisplay.newA = "A. Lava";
                QuestionDisplay.newB = "B. Basalt";
                QuestionDisplay.newC = "C. Magma";
                QuestionDisplay.newD = "D. Ash";
                actualAnswer = "A";
            }
            else if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = "What is the most abundant element in the Earth's crust?";
                QuestionDisplay.newA = "A. Oxygen";
                QuestionDisplay.newB = "B. Aluminum";
                QuestionDisplay.newC = "C. Silicon";
                QuestionDisplay.newD = "D. Iron";
                actualAnswer = "A";
            }
            else if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "Which particle, first theorized in 1964, gives mass to other particles?";
                QuestionDisplay.newA = "A. Higgs Boson";
                QuestionDisplay.newB = "B. Photon";
                QuestionDisplay.newC = "C. Quark";
                QuestionDisplay.newD = "D. Neutrino";
                actualAnswer = "A";
            }
            else if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "What is the second law of thermodynamics primarily concerned with?";
                QuestionDisplay.newA = "A. Entropy";
                QuestionDisplay.newB = "B. Energy Conservation";
                QuestionDisplay.newC = "C. Thermal expansion";
                QuestionDisplay.newD = "D. Heat conduction";
                actualAnswer = "A";
            }
            //all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
