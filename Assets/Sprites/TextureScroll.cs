using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    public Vector2 Dir;

    private Vector2 d2;

    //public float speed;

    //public SpriteRenderer sr;

    public Renderer MM;
    // Start is called before the first frame update
    void Start()
    {
       // sr = GetComponent<SpriteRenderer>();

       // MM = sr.material;
    }

    // Update is called once per frame
    void Update()
    {
        /* float offX = Dir.x;
         float offY = Dir.y; */

        d2.x = d2.x + Dir.x;
        d2.y = d2.y + Dir.y;

        MM.material.mainTextureOffset = new Vector2(d2.x, d2.y);
    }
}
