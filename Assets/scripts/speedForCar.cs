using UnityEngine;
using System.Collections;

public class speedForCar : MonoBehaviour {
	private Rigidbody rb;
	public static double  speedInKPH;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		speedInKPH = rb.velocity.magnitude*3.6;
	}
}
