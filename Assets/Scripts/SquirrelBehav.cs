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

    private bool iWin;

    public GameObject guts, tracker, t2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        t2 = Instantiate(tracker);
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
        if (stopped == false && inAir == false && Time.timeScale > 0)
        {
            //rb.velocity = (transform.right * speed);
            rb.AddRelativeForce (speed,0,0, ForceMode.Acceleration);
        }       
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.right, out hit, 0.8f, LM))
        {
            oneEighty();
        }

        if (Physics.Raycast(transform.position, transform.up * -1, out hit, 1.3f, LM))
        {
            inAir = false;
            rb.useGravity = false;
        }
        else
        {
            inAir = true;
            if (inContruct == false)
            {
                rb.useGravity = true;
            } else
            {
                rb.useGravity = false;
            }
           
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

    public void sleepy()
    {
        speed = 0;
        iWin = true;
    }
    public void die()
    {
        if (iWin == false)
        {
            t2.GetComponent<SQuirrelCount>().death();
            Destroy(t2);
            Destroy(gameObject);
            Instantiate(guts, transform.position, transform.rotation);
        }
        
    }

    public void stuck()
    {
        t2.GetComponent<SQuirrelCount>().death();
    }
}
