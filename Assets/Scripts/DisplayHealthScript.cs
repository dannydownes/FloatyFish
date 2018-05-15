using UnityEngine;
using System.Collections;

public class DisplayHealthScript : MonoBehaviour 
{
	private static int health;
	private string healthText; 
	private GUIStyle guiStyle = new GUIStyle();
	const int labelWidth = 40;
	
	void Start()
	{
		health = 10;
		healthText = "Health:\n" + health.ToString();
	}
	
	public static void MinusHealth()
	{
		health--;
	}
	
	void Update()
	{
		healthText = "Health:\n" + health.ToString();
	}
	
	void OnGUI()
	{
		guiStyle.fontSize = 50;
		guiStyle.normal.textColor = Color.white;
		guiStyle.alignment = TextAnchor.UpperCenter;
		GUI.Label(new Rect(10,10,200,30), healthText, guiStyle);
	}
}
