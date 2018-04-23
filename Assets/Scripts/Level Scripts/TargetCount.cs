using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCount : MonoBehaviour {

    private bool hit = false;

    [SerializeField]
    private Manager theManager;

    public void Start()
    {
        theManager.targetGoal++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!hit && collision.gameObject.tag == "Player")
        {
            theManager.targetGoal--;
            
        }
        hit = true;
    }
}
