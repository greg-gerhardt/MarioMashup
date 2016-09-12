using UnityEngine;
using System.Collections;

public class AmmoCollision : MonoBehaviour {
	public BarretaManager AmmoProp;
	public GameObject AmmoPack;

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.name == "Mario") {
			AmmoProp.Ammo += 10;
			Destroy (AmmoPack);
		}
	}
}
