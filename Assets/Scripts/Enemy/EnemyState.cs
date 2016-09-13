using UnityEngine;
using System.Collections;

public class EnemyState : MonoBehaviour {
	public int Health;
	public GameObject DestroyThis;

	private GameObject ScoreObj;
	private ScoreManager ScrProp;

	// Use this for initialization
	void Start () {
		ScoreObj = GameObject.Find ("Score");
		ScrProp = ScoreObj.GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Health == 0) {
			Destroy (DestroyThis);
			ScrProp.ScoreProperty += 10;
		}
	}
}
