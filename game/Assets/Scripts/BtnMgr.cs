using UnityEngine;
using System.Collections;

public class BtnMgr : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
                if (obj.name == "ChangeBtn1")
                {
                    //チェンジボタン1
                    Debug.Log("b1");
                }
                if (obj.name == "ChangeBtn2")
                {
                    //チェンジボタン2
                    Debug.Log("b2");
                }
                if (obj.name == "ChangeBtn3")
                {
                    //チェンジボタン3
                    Debug.Log("b3");
                }
                if (obj.name == "JumpBtn")
                {
                    //ジャンプボタン
                    Debug.Log("j1");
                }
               
            }
        }
    }
}

