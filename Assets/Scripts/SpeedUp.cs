using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private float baseSpeed;

    public float Speed;

    public bool spedUp;

    public GameObject icon;
    // Start is called before the first frame update
    void Start()
    {
        baseSpeed = Time.timeScale;

        icon.SetActive(false);
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

        if (spedUp == true)
        {
            Time.timeScale = Speed;
            icon.SetActive(true);
        } else
        {
            Time.timeScale = baseSpeed;
            icon.SetActive(false);
        }
    }
}
