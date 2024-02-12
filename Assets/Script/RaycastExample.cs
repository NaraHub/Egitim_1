using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    public LayerMask mask;

    RaycastHit hitInfo;

    public Material selectedMat;
    public Transform gizmo;
    public LineRenderer line;

    public Transform muzzlePoint;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // hitInfo.collider.GetComponent<Renderer>().material = selectedMat;
            GameObject _bullet = Instantiate(bullet, muzzlePoint.position, muzzlePoint.rotation);
            _bullet.GetComponent<Rigidbody>().velocity = _bullet.transform.forward * 50;
        }



        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 100f, mask))
        {
            Debug.Log(hitInfo.collider.name + " Objesine Çarptý");

            gizmo.position = hitInfo.point;

            line.enabled = true;
            line.SetPosition(1, new Vector3(0, 0, hitInfo.distance));
           
        }
        else
        {
            line.enabled = false;
            Debug.Log("Çarpmadý");
        }
    }
}
