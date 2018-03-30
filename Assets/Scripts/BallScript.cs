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

			//setting the parent to none whenever we press the space key for the first time, and then we add the force
			transform.SetParent (null);
			//it will get affected by physics foces again and afterwards we add the force (below)
			rb.isKinematic = false;

			rb.AddForce(new Vector2(ballForce, ballForce));
		}
	}
}
