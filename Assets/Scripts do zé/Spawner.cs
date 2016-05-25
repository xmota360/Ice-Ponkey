using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject balls;
	public bool resetball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (resetball == true) {
			Instantiate (balls);
			resetball = false;
		}
	
	}
}
