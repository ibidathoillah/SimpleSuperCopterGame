using UnityEngine;
using System.Collections;

public class BounceObject : MonoBehaviour
{
    public bool Move = true;    ///gives you control in inspector to trigger it or not
    public float MoveVector; //unity already supplies us with a readonly vector representing up and we are just chaching that into MoveVector
    public float MoveRange = 2.0f; //change this to increase/decrease the distance between the highest and lowest points of the bounce
    public float MoveSpeed = 2f; //change this to make it faster or slower

 

    private BounceObject bounceObject; //for caching this transform

    float startPosition; //used to cache the start position of the transform
    void Start()
    {
        bounceObject = this;
     
        startPosition = bounceObject.transform.position.y;
    }
    void Update()
    {

       
        if (Move) //bool is checked
                  //See if you can work out whats going on here, for your own enjoyment
            bounceObject.transform.position = new Vector2(bounceObject.transform.position.x, startPosition + MoveVector * (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad * MoveSpeed)));

    }
}