using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//When theres a collision between the ball and the bricks this method would be executed
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Ball") {
			//everything that the Ball collides with will be destroyed
			Destroy (gameObject);
		}
	}
}
