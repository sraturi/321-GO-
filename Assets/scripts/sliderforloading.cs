using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sliderforloading : MonoBehaviour {
	public Slider loadingBar;
	public GameObject loadingImage;
	private AsyncOperation async;
	// Use this for initialization

	public void ClickAsync(string level){
		loadingImage.SetActive (true);
		StartCoroutine (loadLevelWithBar (level));

	
	}
	IEnumerator loadLevelWithBar(string level){
		SceneManager.UnloadScene (SceneManager.GetActiveScene ().name);
		async = SceneManager.LoadSceneAsync (level, LoadSceneMode.Single);
		while (!async.isDone) {
			loadingBar.value = async.progress;
			yield return null;
		}
	}
}
