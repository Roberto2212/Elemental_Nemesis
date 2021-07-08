using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script utilizado para el controlador del personaje.


public class Controler : MonoBehaviour 
{
    float h;
    float v;
    Rigidbody2D rb2d;
    public Vector2 velocidad;
    public bool isFacingLeft = true;
    private Animator anim;

	// Use this for initialization
	void Start () 
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Lineas de codigo para los giros de derecha e izquierda.
	void Update () 
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (isFacingLeft && h < 0)
        {
     // Flip al personaje
            Flip();
        }
        else if (!isFacingLeft && h > 0)
        {
            Flip();
        }

        anim.SetFloat("Velocidad_Y", rb2d.velocity.y);

	}
    void FixedUpdate() // Lineas de codigo para la velocidad de movimiento.
    {
        if (h != 0)
        {
            rb2d.velocity = new Vector2(h * velocidad.x, rb2d.velocity.y);
        }
        if (v != 0)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, v * velocidad.y);
        }
    }

    void Flip() // Lineas de codigo para los giel giro del personaje.
    {
        isFacingLeft = !isFacingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
}
