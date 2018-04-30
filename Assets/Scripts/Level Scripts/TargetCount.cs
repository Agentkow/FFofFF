using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCount : MonoBehaviour {
    [SerializeField]
    private bool hit = false;

    [SerializeField]
    private Manager theManager;

    private ParticleSystem gongShine;

    public void Start()
    {
        theManager.targetGoal++;
        gongShine = GetComponent<ParticleSystem>();
        gongShine.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hit && other.gameObject.tag == "Player")
        {
            theManager.targetGoal--;
            hit = true;
            gongShine.Play();
        }
        
    }
}
