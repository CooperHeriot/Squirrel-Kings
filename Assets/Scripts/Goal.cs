using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public float amountN, RN;
    public GameObject Manager;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (RN + "/" + amountN);

        if (RN >= amountN)
        {
            Manager.GetComponent<GameManager>().Win();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SquirrelBehav>() != null)
        {
            RN += 1;
            other.GetComponent<SquirrelBehav>().sleepy();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<SquirrelBehav>() != null)
        {
            RN -= 1;
           // other.GetComponent<SquirrelBehav>().sleepy();
        }
    }
}
