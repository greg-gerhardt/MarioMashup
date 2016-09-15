using UnityEngine;
using System.Collections;

public class CollisionManager : PlayerState {
	public BarretaManager Gun;

	private Rigidbody2D physicsA;

	void Start(){
		physicsA = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			Standing = true;
		}
		if (coll.gameObject.name == "Zombie(Clone)") {
			health -= 1;
			if (coll.gameObject.transform.position.x > transform.position.x) {
				physics.AddForce (new Vector2 (BlowBack.x * -1, BlowBack.y), ForceMode2D.Impulse);
			}
			else {
				physics.AddForce (BlowBack, ForceMode2D.Impulse);
			}
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
