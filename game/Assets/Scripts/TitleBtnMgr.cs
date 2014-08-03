using UnityEngine;
using System.Collections;

public class TitleBtnMgr : MonoBehaviour {

	private bool flag = false;

    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        if (!flag && Input.GetMouseButtonDown(0))
        {
			CameraFade.StartAlphaFade(Color.black, false, 1f, 1f,() => { Application.LoadLevel("GameMain"); });
			flag = true;
        }
    }
}
