using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public Transform Player;

	public Vector2 Margin, Smoothing;

	private Vector3 _max, _min;

	public BoxCollider2D Bounds;

	private bool IsFollowing;

	// Use this for initialization
	void Start () {
	
		_max = Bounds.bounds.max;
		_min = Bounds.bounds.min;
		IsFollowing = true; 
	}
	
	// Update is called once per frame
	void Update () {

		var x = transform.position.x;
		var y = transform.position.y;

		if (IsFollowing) {
			if (Mathf.Abs (x - Player.position.x) > Margin.x) {
				x = Mathf.Lerp (x, Player.position.x, Smoothing.x * Time.deltaTime);
			}
			if (Mathf.Abs (y - Player.position.y) > Margin.y)
				y = Mathf.Lerp (y, Player.position.y, Smoothing.y * Time.deltaTime);
		}

		var CameraWidth = GetComponent<Camera>().orthographicSize * ((float)Screen.width / Screen.height);

		x = Mathf.Clamp (x, _min.x + CameraWidth, _max.x - CameraWidth); 
		y = Mathf.Clamp (y, _min.y + GetComponent<Camera>().orthographicSize, _max.y - GetComponent<Camera>().orthographicSize); 

		transform.position = new Vector3 (x, y, transform.position.z);
	
	}
}
