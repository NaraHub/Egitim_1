using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRCloseGrab : MonoBehaviour
{

    public Transform TouchedObject;
    public Transform GrabbedObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GrabbedObject == null)
            {
                GrabbedObject = TouchedObject;
                GrabbedObject.parent = transform;
            }
            else
            {
                GrabbedObject.parent = null;
                GrabbedObject = null;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        TouchedObject = other.transform;
        Debug.Log(other.name + " Triggered");
    }
    private void OnTriggerExit(Collider other)
    {
        TouchedObject = null;
        Debug.Log(other.name + " Trigger Exit");
    }
}
