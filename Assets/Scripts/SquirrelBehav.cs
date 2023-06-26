using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelBehav : MonoBehaviour
{
    public float speed;

    public float currentRot;

    public bool stopped, inAir;

    private Rigidbody rb;

    public LayerMask LM;

    public bool inContruct;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
        if (stopped == false && inAir == false && Time.timeScale > 0)
        {
            //rb.velocity = (transform.right * speed);
            rb.AddRelativeForce (speed,0,0);
        }       
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.right, out hit, 0.8f, LM))
        {
            oneEighty();
        }

        if (Physics.Raycast(transform.position, transform.up * -1, out hit, 1.1f))
        {
            inAir = false;
        }
        else
        {
            inAir = true;
        }
    }

    public void oneEighty()
    {
        transform.Rotate(0, 180, 0);
    }

    public void Stop()
    {
        stopped = true;
    }

    public void Go()
    {
        stopped = false;
    }

    public void toggleStop()
    {
        stopped = !stopped;
    }
}
