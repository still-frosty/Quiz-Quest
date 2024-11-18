using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void Start()
    {
        //gameSound = GetComponent<AudioSource>();
    }
    //Start the game
    public void Play()
    {
        SceneManager.LoadScene("Menu");
    }

}
