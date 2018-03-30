using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private GameObject uppickedObject;
    private GameObject uppickedRigidbody;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (uppickedObject == null)
            {
                int layer = LayerMask.NameToLayer("Uppickable");
                RaycastHit hitInfo;
                if (Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo, 3.0f, 1 << layer))
                {
                    uppickedObject = hitInfo.collider.gameObject;
                    uppickedObject.transform.parent = transform;

                   
                    ((Rigidbody)uppickedObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
                }
            }
            else
            {
                ((Rigidbody)uppickedObject.GetComponent (typeof(Rigidbody))).isKinematic = false;

                uppickedObject.transform.parent = null;

                uppickedObject = null;
                uppickedRigidbody = null;
            }

        }
    }
}
