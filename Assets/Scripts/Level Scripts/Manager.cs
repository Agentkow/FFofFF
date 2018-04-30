using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour 
{
    public float targetGoal = 0;
    public float dummyGoal = 0;

    [SerializeField]
    private Text targetCount;
    [SerializeField]
    private Text dummyCount;

    private void Awake()
    {
        targetGoal = 0;
    }

    // Update is called once per frame
    void Update () 
	{
        dummyCount.text = "Dummies Left: " + dummyGoal;
        targetCount.text = "Targets Left: " + targetGoal;

        if (dummyGoal == 0 && targetGoal == 0)
        {

            StartCoroutine(GoToMenu());
        }
	}

    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu");
    }
}
