using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource menuMusicSource;
    public AudioSource gameMusicSource;
    public AudioSource sfxSource1;
    public AudioSource sfxSource2;

    private static AudioManager instance; // Singleton instance

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        // Load saved settings
        float musicVolume = PlayerPrefs.GetFloat("MusicVolume", 15f); 
        float sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 15f);

        ApplyMusicVolume(musicVolume);
        ApplySFXVolume(sfxVolume);
    }

    public void ApplyMusicVolume(float volume)
    {
        
        if (menuMusicSource != null) menuMusicSource.volume = volume;
        if (gameMusicSource != null) gameMusicSource.volume = volume;

        // Save the setting
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    public void ApplySFXVolume(float volume)
    {

        if (sfxSource1 != null) sfxSource1.volume = volume;
        if (sfxSource2 != null) sfxSource2.volume = volume;

        // Save the setting
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }
}
