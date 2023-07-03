using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open;
    public GameObject Doort;

    public float raise = 5;

    public Vector3 sart, fin;
    // Start is called before the first frame update
    void Start()
    {
        sart = Doort.transform.position;
        fin = new Vector3 (sart.x, sart.y + raise, sart.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (open == false)
        {
            Doort.transform.position = Vector3.Lerp (Doort.transform.position, sart, Time.deltaTime);
        } else
        {
            Doort.transform.position = Vector3.Lerp(Doort.transform.position, fin, Time.deltaTime);
        }
    }
}
