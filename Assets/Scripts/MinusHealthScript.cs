using UnityEngine;
using System.Collections;

public class MinusHealthScript : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			DisplayHealthScript.MinusHealth();
		}
	}
}