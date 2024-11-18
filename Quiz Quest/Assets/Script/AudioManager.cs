using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private AudioSource gameSound;

    private bool isPlaying = true;

    private void Awake()
    {
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

    private void Start()
    {
        if (gameSound != null)
        {
            gameSound.loop = true;
            gameSound.Play();
        }
    }

    // Function to toggle game sound
    public void ToggleGameSound()
    {
        if (gameSound != null)
        {
            if (isPlaying)
            {
                gameSound.Pause();
            }
            else
            {
                gameSound.Play();
            }
            isPlaying = !isPlaying;
        }
    }
}
