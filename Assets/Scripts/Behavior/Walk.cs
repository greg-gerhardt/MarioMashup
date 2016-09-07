using UnityEngine;
using System.Collections;

public class Walk : AbstractBehavior {

	public float speed = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		var right = inputState.GetButtonValue (inputButtons [0]);
		var left = inputState.GetButtonValue (inputButtons [1]);

		var rightHold = inputState.GetButtonHoldTime (inputButtons [0]);
		var leftHold = inputState.GetButtonHoldTime (inputButtons [1]);
	
		if (right || left) {

			var tmpSpeed = speed;

			var velX = tmpSpeed * (float)inputState.direction;

			body2d.velocity = new Vector2 (velX, body2d.velocity.y);
		}

		//stop mario when no button is pushed
		if (rightHold == 0 && leftHold == 0) {
			body2d.velocity = new Vector2 ( 0, body2d.velocity.y);
		}
	}

}
