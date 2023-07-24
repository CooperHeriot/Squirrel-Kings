using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelStart : MonoBehaviour
{
    public GameObject Suirrel;
    public float amount;
    public float timer;
    private float tt;

    public float offset = 1;

    //public bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        tt = timer;

        for (int i = 0; i < amount; i++)
        {
            GameObject.Find("GameManger").GetComponent<GameManager>().UpdateMax();
        }

        //GameObject.Find("GameManger").GetComponent<GameManager>().UpdateMax();
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
           // Instantiate(Suirrel, transform.position, transform.rotation);
            Instantiate(Suirrel, new Vector3(transform.position.x + Random.Range(-offset, offset), transform.position.y + Random.Range(-offset, offset), transform.position.z), transform.rotation);
            amount -= 1;
            timer = tt;
            
        }

        if (amount < 1)
        {
            GameObject.Find("GameManger").GetComponent<GameManager>().p2 = true;

            gameObject.SetActive(false);
        }
    }
}
