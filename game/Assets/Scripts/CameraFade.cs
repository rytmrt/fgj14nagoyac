using UnityEngine;
using System.Collections;

public class SceneMgr : MonoBehaviour {
    public float lastStrong; //求めるライト強度(0.0～8.0)
    private float lightStrong; //現在ライト強度
    public float fadeSpeed; //フェードのスピード
	// Use this for initialization
	void Start () {
        light.intensity = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (lightStrong <= lastStrong)
            {
                lightStrong += Time.deltaTime * fadeSpeed;
                light.intensity = lightStrong;
            }
        }
	}
}
