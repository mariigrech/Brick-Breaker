using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public UIManager ui;
	public GameObject paddle;
	private Vector3 initialPosition; 

	// Use this for initialization
	void Start (){
		//getting access to the ui manager script within that game object, from this I can call any component
		ui = GameObject.FindWithTag("ui").GetComponent<UIManager> ();
		initialPosition = transform.position;
	}

	public Rigidbody2D rb;
	public float ballForce;
	bool gameStarted = false; //creating a boolean variable and then setting it to false, it will check if the game has started or not
	
	// Update is called once per frame
	void Update () {

		//whenever the space will be pressed the game would start
		if(Input.GetKey(KeyCode.Space)  && gameStarted == false)
		//We are giving it a condition that if the space buttons has been pressed 
		//AND the game hasn't yet started, then the code inside the if statement would be executed
		{

			if (ui.lives == 0) {
				ui.lives = 3;
				ui.liveText.text = "Lives: " + ui.lives;
				ui.GameOverRender.enabled = false;
			}

			//setting the parent to none whenever we press the space key for the first time, and then we add the force
			transform.SetParent (null);
			//it will get affected by physics foces again and afterwards we add the force (below)
			rb.isKinematic = false;

			rb.AddForce(new Vector2(ballForce, ballForce));
			gameStarted = true; //the game has now started and no more force can be added to the ball
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "losing") {
			ui.DecreaseLives ();
			transform.position = initialPosition;
			paddle.transform.position = initialPosition;
			rb.velocity = Vector3.zero;
			gameStarted = false;
		}
	}
}
