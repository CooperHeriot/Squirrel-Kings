using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupConstruct : MonoBehaviour
{
    public GameObject text, hitbox, preview;
    //public bool onOff;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        //hitbox.SetActive(false);
        hitbox.GetComponent<SphereCollider>().enabled = false;
        preview.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activate()
    {
        text.SetActive(true);
        hitbox.GetComponent<SphereCollider>().enabled = true;
        Destroy(preview.gameObject);
    }
}
