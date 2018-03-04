using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour {

    public AudioSource audio;
    public Text lifebar;
    int life = 1;
    public GameObject copterExplosion;


    private void OnCollisionEnter2D(Collision2D col)
    {
       
        

        if (col.gameObject.tag == "copter")
        {
            DestroyObject(col.gameObject);
            Instantiate(copterExplosion, col.transform.position, col.transform.rotation);

            decreaseLife();

            audio.Play();
            audio.Play(44100);

        }
        else if (col.gameObject.tag == "heart")
        {
            life++;
            
        }
        else if (col.gameObject.tag == "palm")
        {
            Instantiate(copterExplosion, gameObject.transform.position, gameObject.transform.rotation);
            SceneManager.LoadScene("gameover");

            audio.Play();
            audio.Play(44100);
        }

        
       


        print(life);
       

    }

    private void decreaseLife()
    {
        life-=1;


        if (life <= 0)
        {
            DestroyObject(gameObject);
            Instantiate(copterExplosion, gameObject.transform.position, gameObject.transform.rotation);
            SceneManager.LoadScene("gameover");

        }
    }

    void Update()
    {
        lifebar.text = "LIFE " + life;
    }
}
	