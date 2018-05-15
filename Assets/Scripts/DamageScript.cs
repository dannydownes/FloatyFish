using UnityEngine;
using System.Collections;

public class DamageScript : MonoBehaviour 
{
	// damage
	public int damage = 100;
	// players or enemies?
	public bool isEnemyShot = false;
	public int DestroyTime = 5;

	//initialization
	void Start () 
	{
		//destroys bullet
		Destroy(gameObject, DestroyTime);	
	}
}
