﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	private void OnTriggerEnter(Collider other)
    {
		Debug.Log(other.gameObject.tag);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
