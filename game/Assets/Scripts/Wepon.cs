using UnityEngine;
using System.Collections;

public class Wepon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var pos = transform.position;
		pos += Vector3.left * 0.05f;
		transform.position = pos;
	}
}
