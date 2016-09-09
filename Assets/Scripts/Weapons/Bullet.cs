using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject DestroyBullet;
	public float speed; //this is really the magnitude of the velocity vector, or the hypotinuse of the right triangle
						// To get the bullet to travel in the right direction, the way the gun is facing,
						// we need to know what the x and y components of the vector are. 

	private const float convert = 57.2958f;
	private GameObject Gun;
	private BarretaManager Properties;
	private Rigidbody2D Body2D;
	private float xCor, yCor;

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

		xCor = cosTriangle (Properties.angle);
		yCor = sinTriangle (Properties.angle);
	}
	
	// Update is called once per frame
	void Update () {
		Body2D.velocity = new Vector2 (xCor, yCor);

		print (cosTriangle (Properties.angle));
		print (sinTriangle (Properties.angle));
	}

	//find the x coordinate of the velocity vector
	float cosTriangle (float angl){
		return speed * ( convert * (Mathf.Cos (angl))); 
	}
		
	//find the y coordinate of the velocity vector
	float sinTriangle (float angl){
		return speed * (convert * (Mathf.Sin (angl)));
	}
}
