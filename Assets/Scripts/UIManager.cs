using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {



	//Variable that will take care of the score
	public int score = 0;
	public int lives = 3;
	//this is where we will be storing our score
	public Text scoreText;
	public Text liveText;
	public Renderer GameOverRender;
	public Renderer YouWin;

	public GameObject ball;

	public void IncrementScore(){
		score ++;
		scoreText.text = "Score: " + score;
	if (score == 8){
				YouWin.enabled = true;
				//Ball will be reset in the middle so as to restart the game
				ball.GetComponent<BallScript>().resetBallAndPaddle();
		} 
	}

	public void DecreaseLives(){
		lives --;
		liveText.text = "Lives: " + lives;

		if (lives == 0){
			GameOverRender.enabled = true;
		} 
	
	}
}
