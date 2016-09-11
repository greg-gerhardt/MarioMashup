using UnityEngine;
using System.Collections;

public abstract class AbstractBehavior : MonoBehaviour {

	public Buttons[] inputButtons;

	//use protected access so outside classes do not have access, only those which 
	//extend this class
	protected InputState inputState;
	protected Rigidbody2D body2d;
	//protected CollisionState collisionState;

	//Awake() is called before Start().  Mark as virtual so 
	//classes extending this class can override this method.
	protected virtual void Awake (){
		inputState = GetComponent<InputState> ();
		body2d = GetComponent<Rigidbody2D> ();
		//collisionState = GetComponent<CollisionState> ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
