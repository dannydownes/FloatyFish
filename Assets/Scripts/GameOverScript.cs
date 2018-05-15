using UnityEngine;

public class GameOverScript : MonoBehaviour
{
	private int score;
	private GUIStyle guiStyle = new GUIStyle();
	private string deathScore;

	
	void Start()
	{
		guiStyle.fontSize = 20;
		guiStyle.normal.textColor = Color.white;
		
		score = PlayerPrefs.GetInt("score", score);
		
		deathScore =  "Your score was: " + score.ToString();
	}
	
	void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 60;
	
		GUI.Label(new Rect(Screen.width/2 - 80,Screen.height/2+60,200,30),deathScore, guiStyle);

		if (GUI.Button(new Rect(Screen.width/2-(buttonWidth/2),(2*Screen.height/3)-(buttonHeight/2),buttonWidth,buttonHeight),"Restart!"))
		{
		// Reload the level
		Application.LoadLevel("flappy");
		}

		if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2),(6 * Screen.height / 8) - (buttonHeight / 2),buttonWidth,buttonHeight),"Menu!"))
		{
		// Reload the level
		Application.LoadLevel("Menu");
		}
	}	
}