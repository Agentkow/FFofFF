using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        dummyGoal = 0;
    }

    // Update is called once per frame
    void Update () 
	{
        dummyCount.text = "Dummies Left: " + dummyGoal;
        targetCount.text = "Targets Left: " + targetGoal;
	}
}
