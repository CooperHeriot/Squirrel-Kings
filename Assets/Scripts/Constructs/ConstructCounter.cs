using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConstructCounter : MonoBehaviour
{
    private TMP_Text text;
    private ConstructBehav CB;
    // Start is called before the first frame update
    void Start()
    {
        //text.text = "djkadas:)";
        text = GetComponent<TMP_Text>();
        CB = GetComponentInParent<ConstructBehav>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (CB.currentA + "/" + CB.requiredA);

        if (CB.currentA == CB.requiredA)
        {
            Destroy(gameObject);
        }
    }
}
