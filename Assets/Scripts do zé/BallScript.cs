﻿using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	public float randommax = 360;
	public float randommin = -360;
	public Vector2 randomgen;
	private Rigidbody2D rbk;
	public Vector2 currentpos;
	public GameObject Spawner;
	public Vector2 SW;
	public Vector2 SE;
	public Vector2 NW;
	public Vector2 NE;
	// Use this for initialization
	void Start () {
		NW = GameObject.Find ("Northwest").transform.position;
		SE = GameObject.Find ("Southwest").transform.position;
		NE = GameObject.Find ("Northeast").transform.position;
		SW = GameObject.Find ("Southeast").transform.position;
		Vector2 newVector = new Vector2(Random.Range(randommin, randommax), Random.Range(randommin ,randommax));
		transform.position = randomgen;
		currentpos = transform.position;
		rbk	= GetComponent<Rigidbody2D> ();
		rbk.AddForceAtPosition (newVector,currentpos);

	}


	// Update is called once per frame
	void Update () {
	
	}

	void SCORE() {
		Spawner.GetComponent<Spawner> ().resetball = true;
		Destroy (gameObject);
	}
}
