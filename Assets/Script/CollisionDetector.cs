using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public Rigidbody rb;
    public float force;

    public GameObject effect;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.forward * force);
    }


    private void OnCollisionEnter(Collision collision)
    { 
        Instantiate(effect, transform.position, Quaternion.identity);
    }

}
