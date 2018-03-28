using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
		
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
