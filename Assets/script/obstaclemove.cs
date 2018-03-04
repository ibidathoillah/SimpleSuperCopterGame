using UnityEngine;
using System.Collections;

public class obstaclemove : MonoBehaviour {
    public Vector2 move = new Vector2(-4, 0);
    public int distanceY = 2;
    public int distanceX = 2;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = move;

        transform.position = new Vector3(transform.position.x - (distanceX * Random.value), transform.position.y - (distanceY * Random.value), transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <  0 || transform.position.y < 0)
        {
            Destroy(gameObject);
        }
	}
}
