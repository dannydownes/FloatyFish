﻿using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour 
{
	// speed
	public Vector2 speed = new Vector2(10, 10);
	// direction
	public Vector2 direction = new Vector2(-1, 0);
	private Vector2 movement;

	void Start () {
	
	}
	

	void Update()
	{
		// Movement
		movement = new Vector2(
		speed.x * direction.x,
		speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		// Apply movement
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}