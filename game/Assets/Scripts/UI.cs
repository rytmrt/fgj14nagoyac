using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	public GameObject runchanObj;

	private Runchan runchan;

	// Use this for initialization
	void Start () {
		this.runchan = this.runchanObj.GetComponent<Runchan>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				if (obj.name == "doragon") runchan.changeDoragonToggle();
			}
		}	

	}
}
