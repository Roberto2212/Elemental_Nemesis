using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script dedicado a la reposicon de objetos a través de colisiones.

public class RepeatingBackground : MonoBehaviour 
{
    private BoxCollider2D groundCollider;
    private float groundVerticalLength;

	// Use this for initialization
	void Start () 
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundVerticalLength = groundCollider.size.y;
        Debug.Log(groundVerticalLength);

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (transform.position.y < -groundVerticalLength)
        {
     //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
            RepositionBackground();
        }
	}
    private void RepositionBackground()
    {
        Vector3 groundOffset = new Vector3(0, groundVerticalLength * 2f, 0);
        transform.position = (Vector3)transform.position + groundOffset;
    }
}
