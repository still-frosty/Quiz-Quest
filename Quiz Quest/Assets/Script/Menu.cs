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
        SceneManager.LoadScene("QuizSportsAndGames");
    }

    public void Entertainment()
    {
        SceneManager.LoadScene("QuizEntertainment");
    }

    public void FoodAndCulture()
    {
        SceneManager.LoadScene("QuizFoodAndCulture");
    }

    public void ScienceAndTech()
    {
        SceneManager.LoadScene("QuizScienceAndTechnology");
    }

    public void HistoryAndNature()
    {
        SceneManager.LoadScene("QuizHistoryAndNature");
    }

    public void Return()
    {
        SceneManager.LoadScene("Start");
    }
}
