using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ObjectForTrigger")
        {
            Debug.Log("Trigger fired");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "ObjectForTrigger")
        {
            Debug.Log("Trigger working...");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "ObjectForTrigger")
        {
            Debug.Log("Trigger anti-fired");
        }
    }
}
