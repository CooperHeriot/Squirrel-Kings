using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            other.GetComponent<SquirrelBehav>().stuck();
        }
    }
}
