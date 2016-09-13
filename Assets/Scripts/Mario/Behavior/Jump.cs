using UnityEngine;
using System.Collections;

public class Jump : AbstractBehavior {

	public float jumpHeight = 10f;
	private CollisionManager isStanding;
	private InputState canJump;

	void Start(){
		isStanding = GetComponent<CollisionManager> (); 
		canJump = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {

		//first checks to see if jump button has been pressed, and then checks to see if 
		//mario is standing on the ground. If mario is not on the ground he cannot jump.
		if(canJump.absVelY < 4f && Input.GetButtonDown("Jump")){	
			body2d.velocity = new Vector2 (body2d.velocity.x, jumpHeight);
		}
	}
}
