using UnityEngine;
using System.Collections;

public class ParallaxManager : MonoBehaviour {
	public float smoothing;
	public float speed;

	public Vector3 previousCameraPos;

	// Use this for initialization
	void Start () {
		previousCameraPos = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 parallax = (previousCameraPos - Camera.main.transform.position) * ((transform.position.z * -1) / smoothing); 

		transform.position = new Vector3 (transform.position.x + parallax.x, transform.position.y + parallax.y, transform.position.z);

		previousCameraPos = Camera.main.transform.position;
	}
}
