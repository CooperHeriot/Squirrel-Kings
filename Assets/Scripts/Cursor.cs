using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Camera cam;

    public GameObject stopBubble, goBubble, ehBubble;

    public bool stopped, gooed, somethinged;

    public GameObject marker, currentMark;
    private Vector3 bublePos;

    public Vector3 screenPos, worldPosition;
    public float dist;

    private BubleBehav b1, b2, b3;

    public GameObject currentConsuct;
    private GameObject moveObj;
    public bool Carrying;
    private bool got;
    // Start is called before the first frame update
    void Start()
    {
        b1 = stopBubble.GetComponent<BubleBehav>();
        b2 = goBubble.GetComponent<BubleBehav>();
        b3 = ehBubble.GetComponent<BubleBehav>();
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Input.mousePosition;
        screenPos.z = dist;

        worldPosition = cam.ScreenToWorldPoint(screenPos);

        currentMark.transform.position = worldPosition;

        bublePos = ((marker.transform.position + currentMark.transform.position) / 2);
        if (Carrying == false)
        {
            if (Input.GetMouseButton(0) && stopped == false && somethinged == false)
            {
                gooed = true;
            }
            else
            {
                gooed = false;
            }
            if (Input.GetMouseButton(1) && gooed == false && somethinged == false)
            {
                stopped = true;
            }
            else
            {
                stopped = false;
            }
            if (Input.GetMouseButton(2) && gooed == false && stopped == false)
            {
                somethinged = true;
            }
            else
            {
                somethinged = false;
            }

            if (Input.GetMouseButtonDown(0) && stopped == false && somethinged == false)
            {
                marker.transform.position = worldPosition;
            }
            if (Input.GetMouseButtonDown(1) && gooed == false && somethinged == false)
            {
                marker.transform.position = worldPosition;
            }
            if (Input.GetMouseButtonDown(2) && gooed == false && stopped == false)
            {
                marker.transform.position = worldPosition;
            }


            if (gooed == true)
            {
                goBubble.SetActive(true);
                goBubble.transform.position = bublePos;
                goBubble.transform.localScale = new Vector3(Vector3.Distance(marker.transform.position, currentMark.transform.position), Vector3.Distance(marker.transform.position, currentMark.transform.position), transform.localScale.z);
            }
            else
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
            if (somethinged == true)
            {
                ehBubble.SetActive(true);
                ehBubble.transform.position = bublePos;
                ehBubble.transform.localScale = new Vector3(Vector3.Distance(marker.transform.position, currentMark.transform.position), Vector3.Distance(marker.transform.position, currentMark.transform.position), transform.localScale.z);
            }
            else
            {
                b3.activate();
                ehBubble.SetActive(false);
            }

        } else
        {
            if (got == true)
            {
                moveObj = Instantiate(currentConsuct, transform.position, transform.rotation);
                
                got = false;
            }
            moveObj.transform.position = currentMark.transform.position;

            if (Input.GetMouseButtonDown(0))
            {
                moveObj.GetComponent<SetupConstruct>().activate();
                moveObj = null;
                Carrying = false;
            }
        }
        

    }

    public void newConstruct(GameObject CC)
    {
        currentConsuct = CC;
        Carrying = true;
        got = true;
    }
}
