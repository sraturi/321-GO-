using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LevelChanger : MonoBehaviour {
	public string level;
	public GameObject loadingImage;
	 void Start(){
		AudioListener.volume = 1;
	}

	public void levelChanger(string Level){
		loadingImage.SetActive (true);
		SceneManager.UnloadScene (SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(Level, LoadSceneMode.Single);

	}

}
