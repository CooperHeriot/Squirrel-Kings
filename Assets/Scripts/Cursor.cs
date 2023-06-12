using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Camera cam;

    public GameObject stopBubble, goBubble;

    public bool stopped, gooed;

    public GameObject marker, currentMark;
    private Vector3 bublePos;

    public Vector3 screenPos, worldPosition;
    public float dist;

    private BubleBehav b1, b2;
    // Start is called before the first frame update
    void Start()
    {
        b1 = stopBubble.GetComponent<BubleBehav>();
        b2 = goBubble.GetComponent<BubleBehav>();
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Input.mousePosition;
        screenPos.z = dist;

        worldPosition = cam.ScreenToWorldPoint(screenPos);

        currentMark.transform.position = worldPosition;

        bublePos = ((marker.transform.position + currentMark.transform.position) / 2);

        if (Input.GetMouseButton(0) && stopped == false)
        {
            gooed = true;
        } else
        {
            gooed = false;
        }
        if (Input.GetMouseButton(1) && gooed == false)
        {
            stopped = true;
        }
        else
        {
            stopped = false;
        }

        if (Input.GetMouseButtonDown(0) && stopped == false)
        {
            marker.transform.position = worldPosition;
        }
        if (Input.GetMouseButtonDown(1) && gooed == false)
        {
            marker.transform.position = worldPosition;
        }


        if (gooed == true)
        {
            goBubble.SetActive(true);
            goBubble.transform.position = bublePos;
            goBubble.transform.localScale = new Vector3(Vector3.Distance(marker.transform.position, currentMark.transform.position), Vector3.Distance(marker.transform.position, currentMark.transform.position), transform.localScale.z);
        } else
        {
            b2.activate();
            goBubble.SetActive(false);
        }
        if (stopped == true)
        {
            stopBubble.SetActive(true);
            stopBubble.transform.position = bublePos;
            stopBubble.transform.localScale = new Vector3(Vector3.Distance(marker.transform.position, currentMark.transform.position), Vector3.Distance(marker.transform.position, currentMark.transform.position), transform.localScale.z);
        }
        else
        {
            b1.activate();
            stopBubble.SetActive(false);
        }

    }
}
