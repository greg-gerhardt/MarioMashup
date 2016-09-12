using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {
	private Vector3 mousePos;
	public float speed;
	public GameObject DestroyBullet;

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.name != "Mario" && coll.gameObject.tag != "Bullet") {
			Destroy (DestroyBullet, 0f);
		}
	}

	void Start(){
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePos.z = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.right * speed * Time.deltaTime;
	}
}
