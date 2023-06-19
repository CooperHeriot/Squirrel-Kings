using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetConstruct : MonoBehaviour
{

    public GameObject Construct;
    public Cursor CC;
    // Start is called before the first frame update
    void Start()
    {
        CC = FindObjectOfType<Cursor>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetConsuct()
    {
        CC.currentConsuct = Construct;
    }
}
