using UnityEngine;
using System.Collections;

public class Janken : MonoBehaviour {

	public GameObject runchanObj;
	private Runchan runchan;
	private int masterHand = 0;

	// Use this for initialization
	void Start () {
		this.runchan = runchanObj.GetComponent<Runchan>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			
			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;

				this.masterHand = Random.Range(0, 2);
				var playerHand = 0;
				if (obj.name == "guu") playerHand = 0;
				if (obj.name == "cyoki") playerHand = 1;
				if (obj.name == "paa") playerHand = 2;

				if (obj.name == "guu" || obj.name == "cyoki" || obj.name == "paa") {

					if (playerHand == this.masterHand) {
						// drow
						runchan.changeEbiToggle();
						runchan.NextFloor();
					}
					else if (playerHand == 0 && this.masterHand == 1 ||
					    playerHand == 1 && this.masterHand == 2 ||
					    playerHand == 2 && this.masterHand == 0) {
						// win
						runchan.NextFloor();
					}
					else {
						// lose
						runchan.changeEbiToggle();
						runchan.NextFloor();
					}
				}
			}
		}	
	}
}
