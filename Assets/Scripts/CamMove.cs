using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float speed;
    private float speed2;
    private float speed3;
    public float zDist, zLock = 2;

    public Vector2 bounds;

    private Vector3 tanfom;
    private float zed;

    private Camera Camm;

    public GameObject background;
    private Vector3 bak;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed / 100;
        speed2 = speed * 3;

        Camm = GetComponent<Camera>();
        //zed = transform.position.z;
        zed = Camm.orthographicSize;

        //background = GetComponentInChildren<GameObject>();
        background = GameObject.Find("Background");
        bak = background.transform.localScale;       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // speed = speed / 100;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed3 = speed2;
        } else
        {
            speed3 = speed;
        }

        transform.position = new Vector3(transform.position.x + (x * speed3), transform.position.y + (y * speed3), transform.position.z);

        tanfom.x = Mathf.Clamp(transform.position.x, -bounds.x, bounds.x);
        tanfom.y = Mathf.Clamp(transform.position.y, -bounds.y, bounds.y);
        tanfom.z = transform.position.z;

        transform.position = tanfom;


        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            zDist -= 1;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            zDist += 1;
        }

        zDist = Mathf.Clamp(zDist, -zLock, zLock);

        Camm.orthographicSize = (zed + zDist);

        background.transform.localScale = new Vector3(bak.x + (zDist * 0.1f), bak.y + (zDist * 0.1f), bak.z + (zDist * 0.1f));
    }
}
