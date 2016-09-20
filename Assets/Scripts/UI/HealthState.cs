using UnityEngine;
using System.Collections;

public class HealthState : MonoBehaviour {
	private GameObject Player;
	private CollisionManager HealthProp;
	private Animator HealthAnim;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Mario");
		HealthProp = Player.GetComponent<CollisionManager> ();
		HealthAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (HealthProp.health < 6) {
			HealthAnim.SetInteger ("HealthOverlayState", 1);
			AnimSpeed (HealthProp.health);
		}
		if (HealthProp.health > 5){
			HealthAnim.SetInteger ("HealthOverlayState", 0);
		}
	}

	void AnimSpeed(int health){
		switch (health){
		case 1:
			HealthAnim.speed = 1f;
			break;
		case 2:
			HealthAnim.speed = 0.8f;
			break;
		case 3:
			HealthAnim.speed = 0.6f;
			break;
		case 4:
			HealthAnim.speed = 0.4f;
			break;
		case 5: 
			HealthAnim.speed = 0.2f;
			break;
		}
	}
}
