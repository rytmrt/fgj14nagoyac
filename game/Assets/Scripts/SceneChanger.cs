using UnityEngine;
using System.Collections;

public class sceneChanger:MonoBehaviour
{
    public string NextName;

    void Start()
    {
        light.intensity = 0.0f;
    }

    void Update()
    {
       
      

    }
    void SceneChange()
    {
        Application.LoadLevel(NextName); 
    }
}