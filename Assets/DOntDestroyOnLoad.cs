using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOntDestroyOnLoad : MonoBehaviour
{
    private static DOntDestroyOnLoad instance;
    // Start is called before the first frame update
    void Awake()
    {
        /*
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        GameObject[] objs = GameObject.FindObjectOfType<DOntDestroyOnLoad>();

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);*/
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
       /// DontDestroyOnLoad(gameObject);
    }
}
