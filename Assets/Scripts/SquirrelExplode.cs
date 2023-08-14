using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelExplode : MonoBehaviour
{
    public float Blast;

    private float timer = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Random.rotation;

       /* for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).transform.position = new Vector3(transform.position.x + Random.Range(-1, 1), transform.position.y + Random.Range(-1, 1), transform.position.z);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            //Destroy(gameObject);
            Destroy(transform.parent.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 11)
        {
            other.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.position - transform.position *((-Blast * 50)) * Time.deltaTime, ForceMode.VelocityChange);
            //other.GetComponent<Rigidbody>().AddForce(0,700,0 * Time.deltaTime);
        }
    }
}
