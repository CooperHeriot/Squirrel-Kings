using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float speed;
    private float speed2;
    private float speed3;
    public float zDist, zLock;

    public Vector2 bounds;

    private Vector3 tanfom;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed / 100;
        speed2 = speed * 3;
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
            zDist += 1;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            zDist -= 1;
        }

        zDist = Mathf.Clamp(zDist, -zLock, zLock);
    }
}
