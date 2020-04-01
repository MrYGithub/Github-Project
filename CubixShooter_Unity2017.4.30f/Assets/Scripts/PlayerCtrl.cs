using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAnim
{
	public AnimationClip idle;
}

public class PlayerCtrl : MonoBehaviour
{
    public int speed = 1;
    public float wingRoll = 10;

    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public Transform bSpawnPoint;
  
    public bool canShoot = true;
	public  float shootDelay = 0.5f;
   	public  float shootTimer = 0;
	

    public GameObject wingTail;
    public int wingSpin = 10;

    public AudioClip shootingSFX;
    public AudioSource AudioSource;

    void Start()
    {
        transform.localScale = new Vector3(0.4f, 0.5f, 0.4f);
        transform.position = new Vector3(0, -4, 0);
        AudioSource.clip = shootingSFX;
    }

    void Update()
    {
        //XY moving.
        transform.Translate
        (4*speed * Time.deltaTime * Input.GetAxis("Horizontal"), Time.deltaTime * speed * Input.GetAxis("Vertical"), 0);

        if (transform.position.x > 3)
        {
            transform.position = new Vector3(3, transform.position.y, 0);
        }


        if ( transform.position.x < -3)
        {
            transform.position = new Vector3(-3, transform.position.y, 0);
        }

         if(transform.position.y >= 3)
        {
            transform.position = new Vector3(transform.position.x, 3, 0);
        }

         if(transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, - 5, 0);
        }


        //Rolling.
        transform.Rotate(0, Time.deltaTime * -wingRoll * Input.GetAxis("Horizontal"), 0);

        // spin.
        wingTail.GetComponent<Transform>().Rotate(0, 20 * wingSpin, 0);

       if(Input.GetMouseButtonDown(0) )
        {
            Instantiate(bulletPrefab, bSpawnPoint.position, Quaternion. identity);
            AudioSource.Play();

        }

       if (Input.GetMouseButtonDown(1) )
        {
            Instantiate(bulletPrefab2, bSpawnPoint.position, Quaternion.identity);
          
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AllKill();
        }


    }

    void AllKill()
    {
        Instantiate(bulletPrefab3, bSpawnPoint.position, Quaternion.identity);
    }
}

