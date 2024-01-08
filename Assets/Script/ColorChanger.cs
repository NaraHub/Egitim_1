using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // public float speed;

    public Color ballColor;
    public MeshRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Baþlangýç");
        // transform.position = transform.position + new Vector3(0.5f,0,0);
        //GetComponent<MeshRenderer>().material.color = ballColor;
        _renderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        //transform.position = transform.position + new Vector3(speed, 0, 0);

      /*  if (Input.GetKeyDown(KeyCode.Space))
        {
            _renderer.material.color = ballColor;
        }*/
    }

    private void OnMouseDown()
    {
        Debug.Log("MouseClicked");
        _renderer.material.color = ballColor;
    }
}
