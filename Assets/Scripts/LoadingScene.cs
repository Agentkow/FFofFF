using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour 
{

    private static string sceneToLoad = "Level";

    [SerializeField]
    private Slider progressBarSlider;

    private void Start()
    {
        StartCoroutine(LoadSceneAsync(sceneToLoad));
    }
    private IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return new WaitForSeconds(0.2f);

        var task = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);

        while (!task.isDone)
        {
            progressBarSlider.value = task.progress;
            yield return null;
        }
        progressBarSlider.value = 1;
        yield return new WaitForSeconds(0.5f);
        SceneManager.UnloadSceneAsync("LoadingScreen");
        
    }
    public static void StartLoadingScene(string nameOfSceneToLoad)
    {
        sceneToLoad = nameOfSceneToLoad;
        SceneManager.LoadScene("LoadingScreen");
    }
}
