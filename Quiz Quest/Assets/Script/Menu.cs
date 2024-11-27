using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   //Choosing which  Category to play

    public void BrainTeasers()
    {
        SceneManager.LoadScene("QuizBoard");
    }

    public void SportsAndGames()
    {
        SceneManager.LoadScene("SportsAndGames");
    }

    public void Entertainment()
    {
        SceneManager.LoadScene("QuizEntertainment");
    }

    public void FoodAndCulture()
    {
        SceneManager.LoadScene("QuizFoodCulture");
    }

    public void ScienceAndTech()
    {
        SceneManager.LoadScene("ScienceAndTechnology");
    }

    public void HistoryAndNature()
    {
        SceneManager.LoadScene("QuizHistoryNature");
    }

    public void Return()
    {
        SceneManager.LoadScene("Start");
    }
}
