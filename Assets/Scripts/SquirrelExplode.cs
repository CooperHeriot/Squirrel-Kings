using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelExplode : MonoBehaviour
{
    public float Blast;

    private float timer = 1;
    // Start is called before the first frame update
    void Start()
    {
       // transform.rotation = 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 11)
        {
            other.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.position - transform.position *((-Blast * 50)) * Time.deltaTime);
        }
    }
}
