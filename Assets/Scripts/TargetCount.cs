using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCount : MonoBehaviour {

    private bool hit = false;

    [SerializeField]
    private Manager theManager;

    public void Awake()
    {
        theManager.targetGoal++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!hit)
        {
            theManager.targetGoal--;
            
        }
        hit = true;
    }
}
