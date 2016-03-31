using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Gravity : MonoBehaviour {

	public GameObject target;

	/*
	// Use this for initialization
	void Start () {
		Debug.LogFormat ("Gravity:{0}\n", Physics.gravity);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Physics.gravity = this.target.transform.position - this.transform.position;
		Debug.LogFormat ("Gravity:{0}\n", Physics.gravity);
	}
	*/

	void Awake() {
		this.GetComponent<Rigidbody> ().useGravity = false;
	}

	void FixedUpdate() {
		//this.GetComponent<Rigidbody> ().AddRelativeForce (this.target.transform.position - this.transform.position);
		//this.GetComponent<Rigidbody> ().AddForce (this.target.transform.position - this.transform.position);
		//this.GetComponent<Rigidbody> ().AddRelativeForce (Target.GetGravity(this.transform.position));
		this.GetComponent<Rigidbody> ().AddForce (Target.GetGravity(this.transform.position));
	}
}
