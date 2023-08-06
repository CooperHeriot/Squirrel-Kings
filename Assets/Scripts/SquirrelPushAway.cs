using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelPushAway : MonoBehaviour
{
    public float force;

    public void OnTriggerStay(Collider other)
    {
        if (other.GetComponentInParent<SquirrelBehav>() != null)
        {
            if (other.GetComponentInParent<SquirrelBehav>().stopped == false && transform.GetComponentInParent<SquirrelBehav>().stopped == false)
            {
                Rigidbody sb = other.gameObject.GetComponentInParent<Rigidbody>();

                //print("fsdjsdnj")

                Vector3 PullRot = sb.gameObject.transform.position - transform.position;
                sb.AddForce(PullRot * ((force * 50)) * Time.deltaTime);
            }

        }
    }
}
