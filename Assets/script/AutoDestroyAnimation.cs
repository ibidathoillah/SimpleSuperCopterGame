using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyAnimation : MonoBehaviour {
    
    public float delay = 0f;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
    }
}

