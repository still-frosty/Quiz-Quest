using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    private static Sound instance;

    public Button button;
    public AudioSource audioSource;
    public AudioClip music;
    public Sprite soundOnSprite;//for sound on
    public Sprite soundOffSprite;//for sound off
    private bool isSoundOn = true;
    private bool isPaused = false;


    void Awake()
    {    //Singleton Instance
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        if (!audioSource.isPlaying)// check if the music is playing
        {
            audioSource.clip = music;
            audioSource.loop = true;
            audioSource.Play();
        }

        //this is for the button function
        if(button != null)
        {
           button.onClick.AddListener(ToggleSound);
            UpdateButtonIcon();
        }
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //play the music sound only in the start and the menu scene
        if (scene.name == "Start" || scene.name == "Menu")
        {
            if (!audioSource.isPlaying && !isPaused)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    void ToggleSound()
    {
        isSoundOn = !isSoundOn;
        //AudioListener.volume = isSoundOn ? 1 : 0;
        
        if ( isSoundOn) /*audioSource != null*/
        {
            audioSource.UnPause(); //mute = !isSoundOn;
        }
        else
        {
            audioSource.Pause();
        }

        UpdateButtonIcon();
    }

    void UpdateButtonIcon()
    {
        if (button.image != null)
        {
            button.image.sprite = isSoundOn ? soundOnSprite : soundOffSprite;
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


}
