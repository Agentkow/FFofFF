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

    private void Awake()
    {
        rigBody = GetComponent<Rigidbody>();
        playerTransform = GetComponent<Transform>();
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
            KickLaunch();
        }
	}

    void KickLaunch()
    {
        rigBody.AddForce(kickForce * cameraTransform.forward + transform.up);
    }
    
}
