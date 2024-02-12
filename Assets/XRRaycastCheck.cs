using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRRaycastCheck : MonoBehaviour
{
    public LayerMask mask;
    RaycastHit hitInfo;
    public Material selectedMat;

    public Transform GrabbedObject;

    public InputActionProperty Trigger;

    private void OnEnable()
    {
        Trigger.action.started += TriggerButtonDown;
        Trigger.action.canceled += TriggerButtonUp;
    }

    private void OnDisable()
    {
        Trigger.action.started -= TriggerButtonDown;
        Trigger.action.canceled -= TriggerButtonUp;

    }


    public void TriggerButtonDown(InputAction.CallbackContext value)
    {
        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 100f, mask))
        {
            Debug.Log(hitInfo.collider.name + " Objesine Çarptý");

            hitInfo.collider.transform.position = transform.position;
            hitInfo.collider.transform.parent = transform;
            GrabbedObject = hitInfo.collider.transform;
        }
        else
        {
            Debug.Log("Çarpmadý");
        }
    }
    public void TriggerButtonUp(InputAction.CallbackContext value)
    {
        if (GrabbedObject != null)
        {
            GrabbedObject.parent = null;
            GrabbedObject = null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GrabbedObject != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GrabbedObject.parent = null;
                GrabbedObject = null;
            }
            return;
        }
        else if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 100f, mask))
        {
            Debug.Log(hitInfo.collider.name + " Objesine Çarptý");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //  hitInfo.collider.GetComponent<Renderer>().material = selectedMat;
                hitInfo.collider.transform.position = transform.position;
                hitInfo.collider.transform.parent = transform;
                GrabbedObject = hitInfo.collider.transform;
            }
        }
        else
        {
            Debug.Log("Çarpmadý");
        }
    }
}
