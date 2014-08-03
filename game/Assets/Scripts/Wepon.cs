using UnityEngine;
using System.Collections;

public class Wepon : MonoBehaviour {
	public int direction;
	private Vector3 vdirection;

	// Use this for initialization
	void Start () {
		this.vdirection = this.direction == 1 ? Vector3.right : Vector3.left;
	}
	
	// Update is called once per frame
	void Update () {
		var pos = transform.position;
		pos += this.vdirection * 0.05f;
		transform.position = pos;
	}
}
