using UnityEngine;
using System.Collections;

public class BarretaShoot : AbstractBehavior {

	public GameObject Bullet; 
	public BarretaManager Properties;
	public Vector2 OffSet;
	public Transform Gun;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var onButton = inputState.GetButtonValue (inputButtons [0]);
		var holdButton = inputState.GetButtonHoldTime (inputButtons [0]);

		var tempOff = Vector2.zero; 
		tempOff.x = Gun.position.x + OffSet.x;
		tempOff.y = Gun.position.y + OffSet.y;
	
		if (onButton && Properties.isActive && holdButton < 0.00001f) {
			Instantiate (Bullet, tempOff, Quaternion.Euler (new Vector3 (0, 0, Properties.angle)));
			print ("Mouse is Clicked");
		}
	}
}
