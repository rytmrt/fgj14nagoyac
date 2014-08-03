using UnityEngine;
using System.Collections;

public class TitleBtnMgr : MonoBehaviour {

    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

            if (aCollider2d)
            {
                GameObject obj = aCollider2d.transform.gameObject;
                if (obj.name == "Start_temp")
                {
                    //チェンジボタン1
                    Debug.Log("bS");

                    CameraFade.StartAlphaFade(Color.white, true, 1f, 1f);
                    CameraFade.StartAlphaFade(Color.white, false, 1f, 1f,()
                        => { Application.LoadLevel("GameMgrTemp"); });
                }
                if (obj.name == "End_temp")
                {
                    //チェンジボタン2
                    Debug.Log("bE");
                }

            }
        }
    }
}
