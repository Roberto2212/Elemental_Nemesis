using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//// Script utilizado para la caida de las islas y su velocidad.
public class ScrollingObject : MonoBehaviour 
{
   public Vector2 velocidad;
   private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () 
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = velocidad;
	}
	
	// Update is called once per frame
	void Update () 
    {
		//if (GameControl.instance.gameOver == true)
        //{
          //  rb2d.velocity = Vector2.zero;
        //}
	}
}
