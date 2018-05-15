using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour 
{
	private WeaponScript weapon;
	
	//initialization
	void Start ()
	{
			
	}

	 void Awake()
	{
		// Retrieve the weapon only once
		weapon = GetComponent<WeaponScript>();
	}
	
	void Update () 
	{
		// Auto-fire
		if (weapon != null && weapon.CanAttack)
		{
			weapon.Attack(true);
		}
	}
	
	void OnDestroy()
	{
		ScoreScript.AddPoint();
	}
}
