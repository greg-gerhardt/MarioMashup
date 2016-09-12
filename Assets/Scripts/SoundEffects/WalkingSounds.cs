using UnityEngine;
using System.Collections;

public class WalkingSounds : MonoBehaviour {
	private AudioSource WalkSnd; 
	private InputState Moving;

	// Use this for initialization
	void Start () {
		WalkSnd = GetComponent<AudioSource> ();
		Moving = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetButtonDown("Horizontal")) {
			WalkSnd.Play ();
		}
		if (Input.GetButtonUp ("Horizontal")) {
			WalkSnd.Stop ();
		}
	}
}
