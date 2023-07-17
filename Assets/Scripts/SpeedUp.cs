using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private float baseSpeed;

    public float Speed;

    public bool spedUp;

    public GameObject icon;

    private Pause PS;
    // Start is called before the first frame update
    void Start()
    {
       // baseSpeed = Time.timeScale;
        baseSpeed = 1;

        icon.SetActive(false);

        PS = GameObject.FindObjectOfType<Pause>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spedUp = true;
        } else
        {
            spedUp = false;
        }

        if (PS.paused == false)
        {
            if (spedUp == true)
            {
                Time.timeScale = Speed;
                icon.SetActive(true);
            }
            else
            {
                Time.timeScale = baseSpeed;
                icon.SetActive(false);
            }
        }   
    }
}
