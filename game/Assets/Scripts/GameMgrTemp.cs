﻿using UnityEngine;
using System.Collections;

public class GameMgrTemp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {
            CameraFade.StartAlphaFade(Color.white, true, 1f, 1f);
            CameraFade.StartAlphaFade(Color.white, false, 1f, 1f, ()
                => { Application.LoadLevel("ResultTemp"); });
        }
	}
}
