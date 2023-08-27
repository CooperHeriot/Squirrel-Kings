using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDaMusicYo : MonoBehaviour
{
    public AudioSource bossTheme;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject musc = GameObject.Find("THASOUNDOFDAMUISC");
        Destroy(musc.gameObject);
        bossTheme.gameObject.SetActive(true);
    }
}
