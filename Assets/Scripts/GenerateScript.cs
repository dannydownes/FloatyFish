using UnityEngine;

public class GenerateScript : MonoBehaviour
{
	public GameObject Object;
	public float spawn = 3f;
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 0f, spawn);
	}
	
	void CreateObstacle()
	{
		Instantiate(Object);
	}
}