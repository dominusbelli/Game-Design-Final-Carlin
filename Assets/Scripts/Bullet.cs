﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 10;

	public GameObject explosion;

	// Use this for initialization
	void Start () {
		GetComponent <Rigidbody2D> ().velocity = transform.up.normalized*speed;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			Instantiate (explosion, other.transform.position, Quaternion.identity);
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag != "Player") 
		{
			Instantiate (explosion, this.transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
