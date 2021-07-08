using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    public Transform trans;
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Isle")
        {
            gameObject.transform.position = trans.position;
        }
    }

}
