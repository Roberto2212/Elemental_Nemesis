using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script dedicado al trigger que se utilizará de detector para la reposicón de opjetos, en este caso las islas.
public class Trigger : MonoBehaviour 
{
   
	void OnTriggerEnter2D(Collider2D col) {
        //Debug.Log(col.gameObject);

        if (col.gameObject.tag == "Isle")
        {
            col.gameObject.transform.position = new Vector3(Random.Range(-6,6),15,0);
        }
    }

    
}

