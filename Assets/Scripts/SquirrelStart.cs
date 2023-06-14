using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelStart : MonoBehaviour
{
    public GameObject Suirrel;
    public float amount;
    public float timer;
    private float tt;
    // Start is called before the first frame update
    void Start()
    {
        tt = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0 && amount >= 1)
        {
            /* for(int i = 0; i < amount; i++)
             {
                 aewd += 1;
                 timer = tt;
             }
             */
            Instantiate(Suirrel, transform.position, transform.rotation);
            amount -= 1;
            timer = tt;
        }

        if (amount < 1)
        {

        }
    }
}
