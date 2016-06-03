using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	public float randommax = 360;
	public float randommin = -360;
	public Vector2 randomgen;
	private Rigidbody2D rbk;
	public Vector2 currentpos;
	// Use this for initialization
	void Start () {
		Vector2 newVector = new Vector2(Random.Range(randommin, randommax), Random.Range(randommin ,randommax));
		currentpos = transform.position;
		rbk	= GetComponent<Rigidbody2D> ();
		rbk.AddForceAtPosition (newVector,currentpos);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
