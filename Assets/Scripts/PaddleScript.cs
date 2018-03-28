using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
		
	void Update(){
		// this input would go from -1 to 0 and to 1 when it moves from left to right
		float x = Input.GetAxis("Horizontal");

		//since we gave the stop variable a zero, I gave the code the directions in which it has to move.

		//if x is smaller than zero that would mean that the controller would move to the left
		if (x < 0){
			MoveLeft();
		}

		//if x is larger than zero that would mean that the controller would move to the right
		if (x > 0){
			MoveRight();
		}

		//if x is equal to zero which is in the middle the paddle would stop in the middle
		if (x == 0){
			Stop ();
		}
	}
	
	void  MoveLeft(){
		// the paddle will move to the left. It has a - (negative sign)
		// infront of speed so now it would move to the left side of the screen
		rb.velocity = new Vector2 (-speed,0);		
	}


	void  MoveRight(){
		// the paddle will move with whatever value we give to the speed valuable.
		// the paddle will move to the right side of the screen
		rb.velocity = new Vector2 (speed,0);
	}

	void  Stop(){
		// if no keys are pressed the paddle would stop moving to neither right or left.
		rb.velocity = Vector2.zero;
	}
}
