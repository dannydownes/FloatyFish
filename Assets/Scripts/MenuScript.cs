using UnityEngine;

public class MenuScript : MonoBehaviour
{		
	void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 60;

		if (GUI.Button(new Rect(Screen.width/2-(buttonWidth/2),(2*Screen.height/3)-(buttonHeight/2),buttonWidth,buttonHeight),"Play!"))
		{
			// Load the level
			Application.LoadLevel("flappy");
		}
		

		
		if (GUI.Button(new Rect(Screen.width/2-(buttonWidth/2),(6*Screen.height/8)-(buttonHeight/2),buttonWidth,buttonHeight),"Quit!"))
		{
			// Reload the level
			Application.Quit();
		}	
	}
}