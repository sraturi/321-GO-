using UnityEngine;
using System.Collections;

public class resetposition : MonoBehaviour {

	private void reset(){
		this.transform.position = Vector3.zero;
	}
	void update(){
		if (Input.GetKeyDown ("Fire1")) {
			reset ();
		}
	}

}
