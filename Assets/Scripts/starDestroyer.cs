﻿using UnityEngine;
using System.Collections;

public class starDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y < -15){
			this.Destroy(gameObject);
		}
	}
}
