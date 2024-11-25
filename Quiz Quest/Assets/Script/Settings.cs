using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;

    private AudioManager audioManager;

    void Start()
    {
        // Find the AudioManager
        audioManager = FindObjectOfType<AudioManager>();

        if (audioManager == null)
        {
            Debug.LogError("No AudioManager found in the scene!");
            return;
        }

        // Initialize sliders with saved values
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", 1f);

        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    void SetMusicVolume(float value)
    {
        if (audioManager != null)
            audioManager.ApplyMusicVolume(value);
    }

    void SetSFXVolume(float value)
    {
        if (audioManager != null)
            audioManager.ApplySFXVolume(value);
    }
}
