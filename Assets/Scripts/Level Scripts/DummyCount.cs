using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCount : MonoBehaviour {
    [SerializeField]
    private bool knockedOver = false;

    [SerializeField]
    private Manager theManager;

    private Light notice;

	// Use this for initialization
	public void Start()
    {
        theManager.dummyGoal++;
        notice = GetComponent<Light>();
	}
   
    private void OnTriggerEnter(Collider other)
    {
        if (!knockedOver && other.gameObject.tag == "Player")
        {
            theManager.dummyGoal--;
            knockedOver = true;
            notice.enabled = false;
        }
        
    }
}
