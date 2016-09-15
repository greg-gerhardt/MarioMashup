using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {
	private GameObject Player;
	private CollisionManager PlayerHealth;
	private Text HealthUI;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Mario");
		PlayerHealth = Player.GetComponent<CollisionManager> ();

		HealthUI = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		HealthUI.text = PlayerHealth.health.ToString ();
	}
}
