using UnityEngine;
using System.Collections;

public class BarretaManager : MonoBehaviour {
	public string Name;

	public int Damage;
	public int Ammo;
	public int TotalAmmo;

	public bool isActive = false;
	public int weaponNum = 0;
	public Transform Player;
	public Vector2 Offset;
	public float angle;

	private Vector3 MouseToWorld;
	private GameObject Gun;
	private Animator GunAnim;

	void Start (){
		Gun = GameObject.Find ("Barreta");
		GunAnim = Gun.GetComponent<Animator> ();
	}

	void Update () {
		MouseToWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		//rotation
		if (isActive) {
			Vector2 tempOff = new Vector2 ();

			tempOff.y = Player.position.y + Offset.y;

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = 5.23f;

			Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
			mousePos.x = mousePos.x - objectPos.x;
			mousePos.y = mousePos.y - objectPos.y;

			angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;

			if (angle < 90f) {
				transform.localRotation = Quaternion.Euler (new Vector3 (0, 0, angle));
			}

			if (angle > 90f || angle < -90f) {
				transform.localRotation = Quaternion.Euler (new Vector3 (180, 0, -(angle)));
			}

			if (Player.localScale.x == -1f) {
				tempOff.x = Player.position.x + -(Offset.x);
				transform.position = tempOff;
			}

			if (Player.localScale.x == 1f) {
				tempOff.x = Player.position.x + Offset.x;
				transform.position = tempOff;
			}

			if (Input.GetKeyDown (KeyCode.R)) {
				StartCoroutine ("Reload");
			}
				
		}
	}

	IEnumerator Reload(){
		GunAnim.SetInteger ("BarretaState", 2);
		AnimatorStateInfo temp = GunAnim.GetCurrentAnimatorStateInfo (0);
		yield return new WaitForSeconds(temp.length);
		Ammo = 10;
	}

}
