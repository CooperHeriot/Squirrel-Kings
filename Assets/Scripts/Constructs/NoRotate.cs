using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotate : MonoBehaviour
{
    //private Quaternion OrigRot;
    public Vector3 offset;
    private GameObject follow;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.localPosition;

        follow = transform.parent.gameObject;
        transform.parent = null;
        //OrigRot = transform.parent.localRotation;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(follow.transform.position.x + offset.x, follow.transform.position.y + offset.y, follow.transform.position.z + offset.z);
      //  transform.localRotation = Quaternion.Inverse(transform.parent.localRotation) * OrigRot * transform.localRotation;

       // OrigRot = transform.parent.localRotation;  
    }
}
