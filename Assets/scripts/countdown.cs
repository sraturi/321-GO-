using UnityEngine;
using System.Collections;

public class countdown : MonoBehaviour {
	private gameManager gm;
	float time =0;
	void Update(){
		time += Time.deltaTime;
		if (time > 5) {
			gm.isCountdownDone = false;
		}
	}
	// Use this for initialization
	public void setCountdown(){
		gm = GameObject.Find ("GameManager").GetComponent<gameManager> ();
		gm.isCountdownDone = true;
	}
}
