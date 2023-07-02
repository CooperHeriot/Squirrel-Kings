using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float currentSquirls, maxSquirrls;

    public GameObject win, lose;
    private bool won, lost;
    // Start is called before the first frame update
    void Start()
    {
        // maxSquirrls = GameObject.FindObjectsOfType<SquirrelBehav>().Length;
        lose.SetActive(false);
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentSquirls = GameObject.FindObjectsOfType<SquirrelBehav>().Length;
    }

    public void UpdateMax()
    {
        maxSquirrls += 1;
    }

    public void Win()
    {
        if (lost == false)
        {
            won = true;

            win.SetActive(true);
        }
    }

    public void Lose()
    {
        if (won == false)
        {
            lost = true;

            lose.SetActive(true);
        }
    }
}
