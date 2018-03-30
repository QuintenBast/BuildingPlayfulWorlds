using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pojectile : MonoBehaviour {

    public float speed;


    private Transform player;
    public Vector3 target;

    public GameObject particle;
    public float partileLifeTime = 2f;


    void OnTriggerEnter(Collider other)
    {
        GameObject _particle = Instantiate(particle, transform.position, transform.rotation); 
        Destroy(_particle, partileLifeTime); 

    }

    void Start(){

        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

     void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y && transform.position.z == target.z)
        {
            DestroyProjectile();
        }
    }

     void OntriggerEnter3D(Collider3D other){
       if (other.CompareTag("Player")){
            DestroyProjectile();
        }
    }

    void DestroyProjectile(){
 
        Destroy(gameObject);
    }

}
