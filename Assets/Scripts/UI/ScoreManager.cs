using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public int ScoreProperty;

	private Text ScoreCounter;

	// Use this for initialization
	void Start () {
		ScoreCounter = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		ScoreCounter.text = ScoreProperty.ToString ();
	}
}
