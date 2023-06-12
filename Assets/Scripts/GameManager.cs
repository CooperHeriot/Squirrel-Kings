using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float currentSquirls, maxSquirrls;
    // Start is called before the first frame update
    void Start()
    {
        maxSquirrls = GameObject.FindObjectsOfType<SquirrelBehav>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        currentSquirls = GameObject.FindObjectsOfType<SquirrelBehav>().Length;
    }
}
