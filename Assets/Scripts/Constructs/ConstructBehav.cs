using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructBehav : MonoBehaviour
{
    public GameObject Contruct;

    public bool isActive;

    public float requiredA, currentA;

    private SphereCollider SC;
    private MeshRenderer MR;
    //public GameObject[] squirls;
    public List<GameObject> squirls = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        SC = GetComponent<SphereCollider>();
        MR = GetComponent<MeshRenderer>();
        Contruct.SetActive(false);
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
            currentA += 1;

            if (currentA >= requiredA)
            {
                assemble();
            }
        }           
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            squirls.Remove(other.gameObject);
            currentA -= 1;
        }
    }

    public void assemble()
    {
        for (int i = 0; i < currentA; i++)
        {
            squirls[i].SetActive(false);
            Contruct.SetActive(true);

            SC.enabled = false;
            MR.enabled = false;
        }
    }

    public void dissasemble()
    {
        for (int i = 0; i < currentA; i++)
        {

        }
    }
}
