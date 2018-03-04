using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestoyedOnHit : MonoBehaviour {

    public GameObject copterExplosion;
   

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(gameObject.tag=="heart")
        {
            DestroyObject(gameObject);
        }
        else
        {

          
            DestroyObject(gameObject);
            Instantiate(copterExplosion, gameObject.transform.position, gameObject.transform.rotation);
        }
           
        

    }






}
