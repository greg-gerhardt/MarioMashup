using UnityEngine;
using System.Collections;

public class WalkingSounds : MonoBehaviour {
	private AudioSource WalkSnd; 

	// Use this for initialization
	void Start () {
		WalkSnd = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		float HAxis = Input.GetAxis ("Horizontal");

		if (Input.GetButtonDown("Horizontal")) {
			WalkSnd.Play ();
		}
		if (Input.GetAxis ("Horizontal") == 0f) {
			WalkSnd.Stop ();
		}

	}
}
