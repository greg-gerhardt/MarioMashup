using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour {
	private Text levelTime;

	// Use this for initialization
	void Start () {
		levelTime = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		float tempTime = Time.timeSinceLevelLoad;
		levelTime.text = string.Format("{0:0.0}",tempTime);
	}
}
