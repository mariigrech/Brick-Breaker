using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {



	//Variable that will take care of the score
	int score = 0;
	int lives = 3;
	//this is where we will be storing our score
	public Text scoreText;
	public Text liveText;

	public void IncrementScore(){
		score ++;
		scoreText.text = "Score: " + score;
	}
	public void DecreaseLives(){
		lives --;
		liveText.text = "Lives: " + lives;
	}
}
