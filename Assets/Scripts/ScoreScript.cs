using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour 
{
	private GUIStyle guiStyle = new GUIStyle();
	private static int score;
	private int highscore;
	private string scoreText; 
	private string highscoreText;
	const int labelWidth = 100;

	
	void Start()
	{
		score = 0;
		scoreText = "Score:\n" + score.ToString();
		highscore = PlayerPrefs.GetInt("highscore", highscore);
		highscoreText = "Highscore:\n" + highscore;
		PlayerPrefs.SetInt("score", score);
	}
	
	public static void AddPoint()
	{
		score++;
	}
	
	void Update()
	{
		scoreText = "Score:\n" + score.ToString();
		
		if (score > highscore)
		{
			highscore = score;
			highscoreText = "Highscore:\n" + highscore;
			
			PlayerPrefs.SetInt("highscore", highscore);
		}
	}
	
	void OnGUI()
	{
		guiStyle.fontSize = 50;
		guiStyle.normal.textColor = Color.white;
		guiStyle.alignment = TextAnchor.UpperCenter;
		GUI.Label(new Rect((Screen.width/2-(labelWidth)),10,100,30), scoreText, guiStyle);
		GUI.Label(new Rect((Screen.width-250),10,100,30), highscoreText, guiStyle);
	}
	
	void OnDestroy()
	{
		PlayerPrefs.SetInt("score", score);
	}
}
