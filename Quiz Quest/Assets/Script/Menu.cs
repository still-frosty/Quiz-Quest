using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   //Choosing which  Category to play

    public void BrainTeasers()
    {
        SceneManager.LoadScene("BrainTeasers");
    }

    public void SportsAndGames()
    {
        SceneManager.LoadScene("SportsAndGames");
    }

    public void Entertainment()
    {
        SceneManager.LoadScene("Entertainment");
    }

    public void FoodAndCulture()
    {
        SceneManager.LoadScene("FoodAndCulture");
    }

    public void ScienceAndTech()
    {
        SceneManager.LoadScene("ScienceAndTechnology");
    }

    public void HistoryAndNature()
    {
        SceneManager.LoadScene("HistoryAndNature");
    }
}
