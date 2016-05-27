using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

	private Vector3 currentPos;
	public float stickVel = 0.1f;
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

	}
}