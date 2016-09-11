using UnityEngine;
using System.Collections;

public class GunShotSound : MonoBehaviour {
	public BarretaManager Properties;

	private AudioSource GunSnd;

	// Use this for initialization
	void Start () {
		GunSnd = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Properties.isActive) {
			GunSnd.Play ();
		}
	}
}
