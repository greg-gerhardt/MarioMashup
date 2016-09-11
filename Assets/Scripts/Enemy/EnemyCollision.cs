using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {
	public EnemyState EnemyProperties;
	public BarretaManager GunDamage;

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Bullet") {
			EnemyProperties.Health -= GunDamage.Damage;
			print (EnemyProperties.Health);
		}
	}
}
