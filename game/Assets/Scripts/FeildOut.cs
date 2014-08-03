using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class FeildOut
    : MonoBehaviour
{
    public float lastStrong; //求めるライト強度(0.0～8.0)
    private float temp; 
    private float lightStrong; //現在ライト強度
    public float fadeSpeed; //フェードのスピード
    public string NextName;

    void Start()
    {
        light.intensity = 0.0f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            while (lightStrong >= lastStrong)
            {
                    lightStrong -= Time.deltaTime * fadeSpeed;
                    temp += Time.deltaTime * fadeSpeed;
                    light.intensity = lightStrong;
                
            }

            lightStrong += temp;
 
            while (lightStrong <= lastStrong)
            {
                lightStrong += Time.deltaTime * fadeSpeed;
                light.intensity = lightStrong;
            }
            Application.LoadLevelAsync(NextName);

        }

    }
}