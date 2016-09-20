using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LevelPicker : MonoBehaviour {
	public void ToLevelOne(){
		SceneManager.LoadScene ("_Secen_0_");
	}
}
