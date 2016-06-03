using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal : MonoBehaviour 
{
	// PUBLIC

	public int score = 0;
	public Text UIScore;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.CompareTag ("Ball")) 
		{
			score++;
			other.GetComponent<BallScript> ().SCORE();

		}
	}

	void Update()
	{
		UIScore.text = "Score = " + score;
	}
}
