using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour {

    public float rotationSpeed;
    public float distance;

    void start(){
        Physics2D.queriesStartInColliders = false;
    }

   
    void Update(){

        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if(hitInfo.collider != null){
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);

            if (hitInfo.collider.CompareTag("player")){
                Destroy(hitInfo.collider.gameObject);
            }

        } else {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }
    }

}
