using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter");
    }

    public void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    public void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
    }

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("TriggerStay");
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerExit");
    }
  
}
