using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject balls;


	// Use this for initialization
	void Start () 
	{
		ResetBall ();
	}
	
	// Update is called once per frame
	void Update () {
		
		}

	public void ResetBall () {
		Instantiate (balls);
	}
}
