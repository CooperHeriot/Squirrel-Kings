using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubleBehav : MonoBehaviour
{
    public bool stopper;

    public bool on, des;
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
            
                if (stopper == true)
                {
                    other.GetComponent<SquirrelBehav>().Stop();
                } else
                {
                    if (des == false)
                    {
                        other.GetComponent<SquirrelBehav>().Go();
                    }
                        
                }
                //on = false;
                //gameObject.SetActive(false);
            
        }
        if (other.GetComponent<DisassembleContrsuct>() != null)
        {
           
                if (des == true)
                {
                    other.GetComponent<DisassembleContrsuct>().dessemble();
                }
            
            //on = false;
        }
    }


    public void activate(){
        on = true;
    }
}
