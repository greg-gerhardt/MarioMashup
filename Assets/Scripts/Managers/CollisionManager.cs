using UnityEngine;
using System.Collections;

public class CollisionManager : PlayerState {
	public BarretaManager Gun;

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			Standing = true;
		}

	}

	void OnCollisionExit2D (Collision2D coll){
		if (coll.gameObject.tag == "Ground"){
			Standing = false;
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.name == "Barreta") {
			Gun.isActive = true;
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.name == "Barreta") {
			Gun.isActive = false;
		}
	}
}
