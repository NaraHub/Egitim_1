using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycleTest : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 10;

    #region StartUp
    private void Awake()
    {
        Debug.Log("Awake");
        rb = GetComponent<Rigidbody>();
    }
    public void OnEnable()
    {
        Debug.Log("Enabled");
    }
    void Start()
    {
        Debug.Log("Start");
        rb.AddForce(Vector3.forward * force * 25);
    }
    #endregion

    #region Updates
    void Update()
    {
        // Debug.Log("Update: " + Time.deltaTime);
    }
    private void FixedUpdate()
    {
        // Debug.Log("FixedUpdate: " + Time.deltaTime);
        // rb.AddForce(Vector3.up * force);
    }
    private void LateUpdate()
    {
        //  Debug.Log("LateUpdate: " + Time.deltaTime);
    }
    #endregion

    #region TearDown

    private void OnDisable()
    {
        Debug.Log("Disable");
    }


    private void OnDestroy()
    {
        Debug.Log("OnDestroy");

    }
    #endregion
}
