using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour {

	public UIManager ui;

	// Use this for initialization
	void Start (){
		//getting access to the ui manager script within that game object, from this I can call any component
		ui = GameObject.FindWithTag("ui").GetComponent<UIManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//When theres a collision between the ball and the bricks this method would be executed
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Ball") {
			ui.IncrementScore ();
			//everything that the Ball collides with will be destroyed
			Destroy (gameObject);
		}
	}
}
