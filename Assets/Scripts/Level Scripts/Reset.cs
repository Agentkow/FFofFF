using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour 
{
    [SerializeField]
    private Transform startPosition;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            other.gameObject.transform.position = startPosition.position;
        }
    }
}
