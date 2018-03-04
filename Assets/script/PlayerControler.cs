using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour {
    float kecepatan = 3;

    //int batas; 
    //float min=1;
    //float maks=8;
    public string nextstage;
    public float timeLeft;
    public Text timeout;
    public GameObject shoot;
    private GameObject currentshoot;
    public float fireRate = 1;
    private float nextFire;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

      
        

       if (Input.GetKey(KeyCode.D))
       {
           transform.position += Vector3.right * kecepatan * Time.deltaTime;           
       }
       if (Input.GetKey(KeyCode.A))
       {
           transform.position += Vector3.left * kecepatan * Time.deltaTime;
       }
       if (Input.GetKey(KeyCode.W))
       {
           transform.position += Vector3.up * kecepatan * Time.deltaTime;
       }
       if (Input.GetKey(KeyCode.S))
       {
           transform.position += Vector3.down * kecepatan * Time.deltaTime;
       }
       if(Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            DestroyObject(currentshoot);
            currentshoot = Instantiate(shoot, new Vector3(gameObject.transform.position.x+2, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
            currentshoot.GetComponent<Rigidbody2D>().velocity = new Vector2(4, 0);


        }



        transform.position = new Vector2(Batas(transform.position.x, 1f, 15f), Batas(transform.position.y, 1f, 11f));

     
        timeLeft -= Time.deltaTime;
        timeout.text = timeLeft.ToString();
        if (timeLeft < 0)
        {       
            SceneManager.LoadScene(nextstage);
        }
    }

    float Batas(float nilai, float min, float maks)
    {
        if (nilai < min) nilai = min;
        if (nilai > maks) nilai = maks;

        return nilai;
    }
}
