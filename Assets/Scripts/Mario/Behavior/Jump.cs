using UnityEngine;
using System.Collections;

public class Jump : AbstractBehavior {

	public float jumpHeight = 10f;
	private CollisionManager isStanding;

	void Start(){
		isStanding = GetComponent<CollisionManager> (); 
	}
	
	// Update is called once per frame
	void Update () {
		var canJump = inputState.GetButtonValue (inputButtons [0]);

		//first checks to see if jump button has been pressed, and then checks to see if 
		//mario is standing on the ground. If mario is not on the ground he cannot jump.
		if(canJump && isStanding.Standing == true){	
			body2d.velocity = new Vector2 (body2d.velocity.x, jumpHeight);
		}
	}
}
