using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour 
{
    public Transform playerTransform;

    [SerializeField]
    private float kickForce = 20;

    [SerializeField]
    private Transform cameraTransform;

    private Rigidbody rigBody;
    private string kickName;
    private bool canKick;

    [SerializeField]
    private ParticleEmitter kickParticles;

    private void Awake()
    {
        rigBody = GetComponent<Rigidbody>();
        playerTransform = GetComponent<Transform>();
        kickParticles.enabled = false;
    }

    private void Start()
    {
        kickName = "Fire1";
    }

    // Update is called once per frame
    void FixedUpdate () 
	{
        if (Input.GetButton(kickName))
        {
            StartCoroutine(KickEffect());
            KickLaunch();
        }
	}

    void KickLaunch()
    {
        rigBody.AddForce(kickForce * cameraTransform.forward + transform.up);
    }

    private IEnumerator KickEffect()
    {
        yield return new WaitForSeconds(10f);
    }
    
}
