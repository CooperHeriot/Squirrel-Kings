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

    public float force;
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

    public void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<SquirrelBehav>() != null)
        {
            Rigidbody sb = other.GetComponent<Rigidbody>();

            Vector3 PullRot = sb.gameObject.transform.position - transform.position;
            sb.AddForce(PullRot * ((-force * 50)) * Time.deltaTime);
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
            squirls[i].transform.position = Contruct.transform.position;
            squirls[i].SetActive(true);

            Contruct.SetActive(false);

            Destroy(transform.parent.gameObject);
        }
    }
}
