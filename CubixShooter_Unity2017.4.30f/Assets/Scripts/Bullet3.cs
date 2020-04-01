using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3 : MonoBehaviour {

	
    public float moveSpeed;
    //public float scaletime = 10.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {

       float moveY = moveSpeed * Time.deltaTime;
       transform.Translate(0, moveY, 0);

        if(transform.position.y > 10)
        {
            Destroy(gameObject);
        }

        

	}
}
