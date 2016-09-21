using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {
	public bool Standing = false;
	public bool hasWeapon = false;

	public int Weapon;
	public int health;
	public int TotalAmmo;

	public Vector2 BlowBack;

	public float direction;
	public Rigidbody2D physics;

	public AudioClip[] soundEffects; 
	public AudioSource SoundSource;

	void Awake (){
		physics = GetComponent<Rigidbody2D> ();
		SoundSource = GetComponent<AudioSource> ();
	}

	void Update (){
		direction = transform.localScale.x;
	}

	public AudioClip FindAudioClip(string clipName){
		for (int i = 0; i < soundEffects.Length; i++)
			if (clipName == soundEffects [i].name) {
				return soundEffects[i];
			}
		return null;
	}
}
