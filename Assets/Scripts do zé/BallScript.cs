using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
	public float rng;
	public float gnr;
	public float rngforme;
	public float randommax = 360;
	public float randommin = -90;
	public float randomone = 2;
	public float randomneg = -2;
	public Vector2 randomgen;
	private Rigidbody2D rbk;
	public Vector2 currentpos;
	// Use this for initialization
	void Start () {
//		rng = Random.Range (randommin, randommax);
//		gnr = Random.Range (randommin, randommax);
//		rngforme = Random.Range (randomneg, randomone);
		Vector2 newVector = new Vector2(Random.Range(-360, 360), Random.Range(-360 ,360));
//		randomgen.x = rng*rngforme;
//		randomgen.y = gnr*rngforme;
		currentpos = transform.position;
		rbk	= GetComponent<Rigidbody2D> ();
		rbk.AddForceAtPosition (newVector,currentpos);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
