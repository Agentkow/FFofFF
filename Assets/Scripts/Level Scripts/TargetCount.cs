using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCount : MonoBehaviour {
    [SerializeField]
    private bool hit = false;

    [SerializeField]
    private Manager theManager;

    public void Start()
    {
        theManager.targetGoal++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hit && other.gameObject.tag == "Player")
        {
            theManager.targetGoal--;
            hit = true;
        }
        
    }
}
