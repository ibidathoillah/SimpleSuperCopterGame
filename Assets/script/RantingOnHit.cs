using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RantingOnHit : MonoBehaviour {


    public GameObject copterExplosion;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag != "player")
        {
            DestroyObject(gameObject);
            Instantiate(copterExplosion, gameObject.transform.position, gameObject.transform.rotation);


        }

    }
}
