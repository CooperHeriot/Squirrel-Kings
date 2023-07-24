using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQuirrelCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GameManger").GetComponent<GameManager>().currentSquirls += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void death()
    {
        GameObject.Find("GameManger").GetComponent<GameManager>().currentSquirls -= 1;
    }

    public void unDeath()
    {
        GameObject.Find("GameManger").GetComponent<GameManager>().currentSquirls += 1;
    }
}
