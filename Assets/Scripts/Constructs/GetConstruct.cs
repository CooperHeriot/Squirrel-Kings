using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetConstruct : MonoBehaviour
{

    public GameObject Construct;
    public Cursor CC;
    public AudioSource aS;
    // Start is called before the first frame update
    void Start()
    {
        // CC = FindObjectOfType<Cursor>();   
        CC = GameObject.Find("player").GetComponent<Cursor>();
        aS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetConsuct()
    {
        // CC.currentConsuct = Construct;

        CC.newConstruct(Construct);

        aS.Play();
    }
}
