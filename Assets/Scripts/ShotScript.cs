using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour 
{
	// damage
	public int damage = 1;
	// players or enemies?
	public bool isEnemyShot = false;

	//initialization
	void Start () 
	{
		//destroys bullet
		Destroy(gameObject, 10);	
	}
	
	void OnCollisionEnter2D()
	{
		Destroy(gameObject);
	}
}
