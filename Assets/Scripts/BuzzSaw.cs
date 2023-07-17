using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzSaw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            if ((other.GetComponent<SquirrelBehav>().inContruct == false))
            {
                other.GetComponent<SquirrelBehav>().die();
            }
        }

        if (other.GetComponent<DisassembleContrsuct>() != null)
        {
            other.GetComponent<DisassembleContrsuct>().dessemble();
        }
    }
}
