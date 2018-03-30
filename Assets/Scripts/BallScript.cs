using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float ballForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//whenever the space will be pressed the game would start
		if(Input.GetKey(KeyCode.Space)){
			rb.AddForce(new Vector2(ballForce, ballForce));
		}
	}
}
