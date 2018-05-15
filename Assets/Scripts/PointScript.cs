using UnityEngine;
using System.Collections;

public class PointScript : MonoBehaviour 
{
	public AudioSource sound1;
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			ScoreScript.AddPoint();
			sound1.Play();
		}
	}	
}
