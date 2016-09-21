/*
 *  This class connects up the animations and will know the state of 
 *  each of the behaviors and be able to update the display accordingly. 
*/
using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	private InputState inputState;
	//private Walk walkBehavior;
	private Animator animator;

	private CollisionManager Death;



	void Awake () {
		inputState = GetComponent<InputState> ();
		//walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
		Death = GetComponent<CollisionManager> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (inputState.absVelX == 0) {
			ChangeAnimationState (0);
		}
		if (inputState.absVelX > 0) {
			ChangeAnimationState (1);
		}
		if (Death.health <= 0) {
			ChangeAnimationState (2);
		}

	}

	void ChangeAnimationState(int value){
		animator.SetInteger ("AnimState", value);
	}


}
