using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakAway : MonoBehaviour {

    [SerializeField]
    private float force = 100f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(-transform.forward * force, ForceMode.Acceleration);
        rb.useGravity = true;
    }
}
