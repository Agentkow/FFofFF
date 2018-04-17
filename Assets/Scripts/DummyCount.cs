using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCount : MonoBehaviour {

    private bool knockedOver = false;

    [SerializeField]
    private Manager theManager;

	// Use this for initialization
	public void Awake()
    {
        theManager.dummyGoal++;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (!knockedOver)
        {
            theManager.dummyGoal--;
            
        }
        knockedOver = true;
    }
}
