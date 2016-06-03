using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

	private Vector3 currentPos;
	private Vector3 posLimit;
	public float stickVel = 0.1f;

	public float limitUp = 3.85f;
	public float limitDown = -3.85f;

	// Use this for initialization
	void Start () 
	{
		currentPos = transform.position;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("up"))

			currentPos.y = transform.position.y + 1*stickVel;

		if (Input.GetKey ("down"))

			currentPos.y = transform.position.y - 1*stickVel;

		transform.position = currentPos;

		if (transform.position.y > limitUp) 
		{
			posLimit = new Vector3 (transform.position.x, limitUp, transform.position.z);
			transform.position = posLimit;
		}

		if (transform.position.y < limitDown)
		{
			posLimit = new Vector3 (transform.position.x, limitDown, transform.position.z);
			transform.position = posLimit;
		}
	}
}