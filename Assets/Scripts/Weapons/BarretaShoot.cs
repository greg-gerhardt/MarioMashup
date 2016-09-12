using UnityEngine;
using System.Collections;

public class BarretaShoot : AbstractBehavior {

	public GameObject Bullet; 
	public GameObject Barreta;
	public BarretaManager Properties;
	public Vector2 OffSet;
	public Transform Gun;

	private Animator State;

	// Use this for initialization
	void Start () {
		State = Barreta.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		var onButton = inputState.GetButtonValue (inputButtons [0]);
		var holdButton = inputState.GetButtonHoldTime (inputButtons [0]);

		var tempOff = Vector2.zero; 
		tempOff.x = Gun.position.x + OffSet.x;
		tempOff.y = Gun.position.y + OffSet.y;
	 
		if (onButton && Properties.isActive && holdButton < 0.00001f && Properties.Ammo != 0) {
			Instantiate (Bullet, tempOff, Quaternion.Euler (new Vector3 (0, 0, Properties.angle)));
			State.SetInteger ("BarretaState", 1);
			Properties.Ammo -= 1;
		} 
		else {
			State.SetInteger ("BarretaState", 0);
		}
	}
}
