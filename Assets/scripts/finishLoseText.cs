using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class finishLoseText : MonoBehaviour {
	Text winLose;
	bool iswonLose = false;
	string decision;
	// Use this for initialization
	void Start () {
		winLose = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		winLose.text = decision;
		if (gameManager.finalPlayerPosition == 1 && iswonLose == false ) {
			decision = "CONGRATS YOU WON!\n" + "Position: "+ gameManager.finalPlayerPosition;
			iswonLose = true;

		} if (gameManager.finalPlayerPosition >1 &&iswonLose == false){
			decision = "YOU LOST :( \n"  + " Position: " + gameManager.finalPlayerPosition  ;
			iswonLose = true;

		}
	}
}
