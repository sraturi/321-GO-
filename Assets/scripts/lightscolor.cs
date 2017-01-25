using UnityEngine;
using System.Collections;

public class lightscolor : MonoBehaviour {
	private Renderer mat;
	// Use this for initialization
	void Start () {
		mat = GetComponent<Renderer> ();
	}
	float time =0;
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time>3){
		mat.material.color = Color.green;
	}
		if (time > 5) {
			mat.material.color = Color.red;
		}
}
}
