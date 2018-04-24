using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCount : MonoBehaviour {
    [SerializeField]
    private bool knockedOver = false;

    [SerializeField]
    private Manager theManager;

	// Use this for initialization
	public void Start()
    {
        theManager.dummyGoal++;
	}
   
    private void OnTriggerEnter(Collider other)
    {
        if (!knockedOver && other.gameObject.tag == "Player")
        {
            theManager.dummyGoal--;
            knockedOver = true;
        }
        
    }
}
