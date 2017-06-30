using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
	private Rigidbody2D flappy;
	private PlayMakerFSM fsm;

	void Awake(){
//		Vector2 velocity = flappy.velocity;
//		velocity.y = 0.5;
//		flappy.velocity.y = velocity;
		flappy = GetComponent<Rigidbody2D> ();
		fsm = GetComponent<PlayMakerFSM> ();
	}

	public void addForce(Vector2 force){
		Vector2 velocity = flappy.velocity;
		velocity.y = 0;
		if (flappy.velocity.y < 0) {
			flappy.velocity = velocity;
		}
		flappy.AddForce (force);
	}

	public void OnCollisionEnter2D(Collision2D col){
		fsm.SendEvent ("GameOver");
	}
}
