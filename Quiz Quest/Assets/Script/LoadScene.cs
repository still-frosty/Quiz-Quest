using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject loadingScreen;
    public Image loadingSlider;

    public void LoadingScene(int levelIndex)
    {
        StartCoroutine(LoadSceneAsync(levelIndex));
    }

    IEnumerator LoadSceneAsync(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);

        loadingScreen.SetActive(true); // make the loading panel active

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            //loadingSlider.value = progressValue;
            loadingSlider.fillAmount = progressValue;
            Debug.Log("Loading Progress: " + operation.progress);
           
            yield return null;
        }
    }



}
