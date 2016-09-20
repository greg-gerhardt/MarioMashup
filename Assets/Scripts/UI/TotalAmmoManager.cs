using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalAmmoManager : MonoBehaviour{
	private GameObject Player;
	private PlayerState Properties;
	private Text TAText;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Mario");
		Properties = Player.GetComponent<PlayerState> ();

		TAText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		TAText.text = " / " + Properties.TotalAmmo.ToString ();
	}
}
