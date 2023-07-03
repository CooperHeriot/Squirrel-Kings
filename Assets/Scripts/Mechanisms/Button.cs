using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //public float amount = 1;
    public bool pushed;

    public Door dr;

    public GameObject model;
    private Vector3 MS, MF;

    public float lower;
    // Start is called before the first frame update
    void Start()
    {
        MS = model.transform.position;
        MF = new Vector3(MS.x, MS.y - lower, MS.z);   
    }

    // Update is called once per frame
    void Update()
    {
        if (pushed == true)
        {
            dr.open = true;

            model.transform.position = Vector3.Lerp(model.transform.position, MF, Time.deltaTime);
        }
        else
        {
            dr.open = false;

            model.transform.position = Vector3.Lerp(model.transform.position, MS, Time.deltaTime);
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        
    }*/
    private void OnTriggerStay(Collider other)
    {
         if (other.GetComponent<SquirrelBehav>() != null)
        {
            pushed = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            pushed = false;
        }
    }
}
