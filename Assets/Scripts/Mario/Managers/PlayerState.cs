using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {
	public bool Standing = false;
	public bool hasWeapon = false;

	public int Weapon;
	public int health;
	public int TotalAmmo;

	public Vector2 BlowBack;

	public float direction;
	public Rigidbody2D physics;

	void Start (){
		physics = GetComponent<Rigidbody2D> ();
	}

	void Update (){
		direction = transform.localScale.x;
	}
}
