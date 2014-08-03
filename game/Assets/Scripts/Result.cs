using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {

	private bool flag = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!flag && Input.GetMouseButtonDown(0))
		{
			CameraFade.StartAlphaFade(Color.black, false, 1f, 1f,() => { Application.LoadLevel("GameTitle"); });
			flag = true;
		}
	}
}
