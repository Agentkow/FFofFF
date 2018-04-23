using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour 
{

    [SerializeField]
    private string sceneToLoad;

    public void LoadButtonOnClick()
    {
        LoadingScene.StartLoadingScene(sceneToLoad);
    }

    public void QuitButton()
    {

    }
}
