using UnityEngine;
using System.Collections;

public class finishLine : MonoBehaviour {
	bool first,second,third;
	// Use this for initialization
	void Start () {
		first = false;
		second = false;
		third = false;
	}
	
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"|| other.tag == "rival"|| other.tag == "rival2"){
			if (first == false) {
			if (other.tag == "Player") {
				gameManager.finalPlayerPosition = 1;
				first = true;
			} else {
				first = true;
			}
		} 
		else if (first && second == false) {
			if (other.tag == "Player") {
				gameManager.finalPlayerPosition = 2;
				second = true;
			} else {
				second = true;
			}
		}
		else if (third == false) {
			if (other.tag == "Player") {
				gameManager.finalPlayerPosition = 3;
				third = true;
			} else {
				third = true;
			}
		}
	}
	}
}
