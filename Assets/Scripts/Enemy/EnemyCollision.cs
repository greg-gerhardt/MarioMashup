using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {
	public EnemyState EnemyProperties;
	public BarretaManager GunDamage;
	public EnemyManagre Blowback;
	public float InvBlow;

	private Rigidbody2D Zombie;

	void Start(){
		Zombie = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Bullet") {
			EnemyProperties.Health -= GunDamage.Damage;
			print (EnemyProperties.Health);
			Zombie.AddForce (-(Blowback.InverseMagnitude) * InvBlow, ForceMode2D.Impulse);
		}
	}
}
