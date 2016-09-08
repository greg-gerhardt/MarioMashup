using UnityEngine;
using System.Collections;

public class CollisionManager : MonoBehaviour {

	public bool Standing = false;

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
