using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
    static MusicManager instance = null;
    // Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(gameObject);
        if (instance != null)
        {
            print("destroy");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
