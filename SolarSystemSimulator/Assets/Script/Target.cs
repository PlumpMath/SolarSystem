using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Target : MonoBehaviour {

	public static readonly List<Target> targets = new List<Target>();

	public float Range;
	public Transform target;

	private void Awake() {
		targets.Add (this);
	}

	private void FixedUpdate() {
		//Debug.LogFormat ("Distance:{0}\n", Vector3.Distance(this.target.transform.position, this.transform.position));
	}

	/*
	public static Vector3 GetGravity(Vector3 pos) {
		float distance = float.MaxValue;
		Vector3 result = Vector3.zero;
		targets.ForEach (t => {
			float currDist = Vector3.Distance(t.transform.position, pos);
			if (currDist <= distance) {
				distance = currDist;
				result = t.transform.position - pos;
			}
		});

		return result;
	}
	*/

	public static Vector3 GetGravity(Vector3 pos) {
		//float distance = float.MaxValue;
		Vector3 result = Vector3.zero;
		targets.ForEach (t => {
			float currDist = Vector3.Distance(t.transform.position, pos);
			if (currDist <= t.Range) {
				result += t.transform.position - pos;
			}
		});

		return result;
	}

	private void OnDrawGizmos() {
		UnityEditor.Handles.color = Color.yellow;
		UnityEditor.Handles.DrawWireDisc (this.transform.position, Vector3.back, this.Range);
		UnityEditor.Handles.DrawWireDisc (this.transform.position, Vector3.right, this.Range);
		UnityEditor.Handles.DrawWireDisc (this.transform.position, Vector3.left, this.Range);
		UnityEditor.Handles.DrawWireDisc (this.transform.position, Vector3.forward, this.Range);
		UnityEditor.Handles.DrawWireDisc (this.transform.position, Vector3.down, this.Range);
		UnityEditor.Handles.DrawWireDisc (this.transform.position, Vector3.up, this.Range);
	}
}
