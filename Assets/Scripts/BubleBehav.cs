using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubleBehav : MonoBehaviour
{
    public bool stopper;

    public bool on;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            print("dsds");
            if (on == true)
            {
                if (stopper == true)
                {
                    other.GetComponent<SquirrelBehav>().Stop();
                } else
                {
                    other.GetComponent<SquirrelBehav>().Go();
                }
                on = false;
                //gameObject.SetActive(false);
            }
        }
    }


    public void activate(){
        on = true;
    }
}
