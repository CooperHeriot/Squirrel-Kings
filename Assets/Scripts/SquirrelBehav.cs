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

    private Quaternion slopeRotation;
    // public Animator anim;
    public GameObject sprites, idle, run;
    public bool swit;
    public ParticleSystem PS, AA;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        PS = GetComponent<ParticleSystem>();

        t2 = Instantiate(tracker);

        AA.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
        if (stopped == false && inAir == false && Time.timeScale > 0)
        {
            //rb.velocity = (transform.right * speed);
            rb.AddRelativeForce (speed,0,0, ForceMode.Acceleration);

           // run.SetActive(true);
           // idle.SetActive(false);
        } else
        {
          //  run.SetActive(false);
          //  idle.SetActive(true);
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

            //transform.rotation = Quaternion.LookRotation(hit.normal);
            //transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, Quaternion.LookRotation(hit.normal).z, 0);
            //transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, Quaternion.FromToRotation(transform.up, hit.normal).z, 0);
            slopeRotation = Quaternion.FromToRotation(transform.up, hit.normal);
            sprites.transform.rotation = Quaternion.Slerp(sprites.transform.rotation, slopeRotation * transform.rotation, 100 * Time.deltaTime);
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

            sprites.transform.rotation = new Quaternion(sprites.transform.rotation.x, sprites.transform.rotation.y, 0,0);
           
        }

        if (stopped == true && swit == false)
        {
            idleAnim();
            swit = true;
        }
        if (stopped == false && swit == true)
        {
            runAnim();
            swit = false;
        }
    }
    public void runAnim()
    {
        run.SetActive(true);
        idle.SetActive(false);
        PS.Play();
    }
    public void idleAnim()
    {
        run.SetActive(false);
        idle.SetActive(true);
        PS.Play();
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

        idleAnim();
        //AA.Play();
        AA.gameObject.SetActive(true);
        print("wah");
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
