using UnityEngine;
using System.Collections;

public class Jump : AbstractBehavior {

	public float jumpHeight = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var canJump = inputState.GetButtonValue (inputButtons [0]);
		var holdTime = inputState.GetButtonHoldTime (inputButtons [0]);

		if(canJump && holdTime < .1f){	
			body2d.velocity = new Vector2 (body2d.velocity.x, jumpHeight);
		}
	}
}
