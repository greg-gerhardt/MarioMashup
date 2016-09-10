using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public GameObject DestroyBullet;
	public float Magnitude; //this is really the magnitude of the velocity vector, or the hypotinuse of the right triangle
							// To get the bullet to travel in the right direction, the way the gun is facing,
							// we need to know what the x and y components of the vector are. 

	private float AngleDirection;
	private const float convert = 57.2958f;
	private GameObject Gun;
	private BarretaManager Properties;
	private Rigidbody2D Body2D;
	private Vector3 objectPos;
	private Vector3 mousePos; //this will house our x and y components

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.name != "Mario" && coll.gameObject.tag != "Bullet") {
			Destroy (DestroyBullet, 0f);
		}
	}

	// Use this for initialization
	void Start () {
		Body2D = GetComponent<Rigidbody2D> ();
		Gun = GameObject.Find ("Barreta");
		Properties = Gun.GetComponent<BarretaManager> ();

		mousePos = Input.mousePosition;
		mousePos.z = 5.23f;

		objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;

		print (mousePos);
		print (Slope (mousePos.x, mousePos.y));
		AngleDirection = Properties.angle;
	}
	
	// Update is called once per frame
	void Update () {
		if (AngleDirection > 90f || AngleDirection < -90f) {
			Body2D.velocity = new Vector2 (-(Magnitude), -(yFinder (Slope (mousePos.x, mousePos.y)))); 
		} 
		else {
			Body2D.velocity = new Vector2 (Magnitude, yFinder (Slope (mousePos.x, mousePos.y))); 
		}
	}

	//We find the slope to find a y coordinate at the end of line, 
	//and we use a consistant magnitude of velocity at the x coordinate 
	//to keep the bullet's velocity consistant no matter where the mouse is.
	float Slope(float x, float y){
		var m = y / x;
		return m;
	}

	float yFinder (float m){
		return m * Magnitude; 
	}
}
