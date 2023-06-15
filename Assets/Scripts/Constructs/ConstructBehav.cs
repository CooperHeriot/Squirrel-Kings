using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructBehav : MonoBehaviour
{
    public GameObject Contruct;

    public bool isActive;

    public float requiredA, currentA;

    //public GameObject[] squirls;
    public List<GameObject> squirls = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            squirls.Add(other.gameObject);
        }           
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            squirls.Remove(other.gameObject);
        }
    }
}
