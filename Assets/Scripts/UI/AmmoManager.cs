using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoManager : MonoBehaviour {
	public BarretaManager AmmoProp;

	private Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		AmmoText.text = AmmoProp.Ammo.ToString ();
	}
}
