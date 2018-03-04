using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {


    public Vector2 move = new Vector2(4, 0);

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = move;
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       
            DestroyObject(gameObject);
    



    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 16)
        {
            Destroy(gameObject);
        }
    }
}
