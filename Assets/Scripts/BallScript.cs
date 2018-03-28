using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float ballForce;

	// Use this for initialization
	void Start () {
		rb.AddForce(new Vector2(ballForce, ballForce));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
