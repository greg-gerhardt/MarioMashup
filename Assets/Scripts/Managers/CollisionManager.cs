using UnityEngine;
using System.Collections;

public class CollisionManager : PlayerState {

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.name == "Ground") {
			Standing = true;
		}
	}

	void OnCollisionExit2D (Collision2D coll){
		if (coll.gameObject.name == "Ground"){
			Standing = false;
		}
	}
}
