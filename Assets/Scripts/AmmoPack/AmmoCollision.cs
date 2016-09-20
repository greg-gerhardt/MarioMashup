using UnityEngine;
using System.Collections;

public class AmmoCollision : MonoBehaviour {
	public PlayerState AmmoProp;
	public GameObject AmmoPack;

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.name == "Mario") {
			AmmoProp.TotalAmmo += 10;
			Destroy (AmmoPack);
		}
	}
}
