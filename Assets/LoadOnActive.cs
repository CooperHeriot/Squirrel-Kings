using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnActive : MonoBehaviour
{
    public string lev;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(lev);
    }

}
