﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y + .1f, transform.position.z);
	}
}
