using UnityEngine;
using System.Collections;

public class obstaclegenerator : MonoBehaviour {
    public GameObject obstacle;
    public float time;
    public float repeatRate;
	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacle", time, repeatRate);
	}
	
	// Update is called once per frame
	void CreateObstacle () {
	    Instantiate(obstacle);
	}
}
