using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour {

    public AudioClip saw; 

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

     void OnCollisionEnter(Collision collision)
    {
        GameObject enemy = collision.gameObject;
        if(enemy.name == "Target")
        {
            Destroy(enemy);
            GetComponent<AudioSource>().Play();
        }





    }

    // Update is called once per frame
    void Update () {
		
	}
}
