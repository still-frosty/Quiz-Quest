using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnScript : MonoBehaviour
{
    public GameObject About;
    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
    public void InfoButton()
    {
        About.SetActive(true); // make the about panel active
    }
    public void CloseAbout()
    {
        About.SetActive(false); // Close the about panel
    }
}
