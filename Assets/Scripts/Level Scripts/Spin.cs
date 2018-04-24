using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour 
{
    private float force = 100;
    private Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
        rb = GetComponent<Rigidbody>();
	}

    void OnTriggerEnter(Collider other)
    {
        rb.AddForce(transform.up*force, ForceMode.Acceleration);
    }
}
