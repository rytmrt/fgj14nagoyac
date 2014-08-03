using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	public GameObject floorObj;
	public GameObject runchanObj;

	private Runchan runchan;
	private int floorNum = 0;
	private bool flag = false;

	// Use this for initialization
	void Start () {
		this.runchan = runchanObj.GetComponent<Runchan>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.floorNum == this.runchan.floorNum) {
			var dir = runchan.GetDirection();
			var obj = Instantiate(floorObj) as GameObject;
			obj.transform.parent = this.transform;
			var pos = obj.transform.position;
			pos.y = (floorNum+1) * 6.4f;
			obj.transform.position = pos;
			var scale = obj.transform.localScale;
			scale.x *= dir == 0 ? -1 : 1;
			obj.transform.localScale = scale;
			this.floorNum ++ ;
		}

		if (!flag && runchan.life <= 0) {
			CameraFade.StartAlphaFade(Color.black, false, 1f, 1f,() => { Application.LoadLevel("GameResult"); });
			flag = true;
		}
	}
}
