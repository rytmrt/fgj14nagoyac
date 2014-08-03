using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {
	
	public GameObject runchanObj;
	private Runchan runchan;
	private Animator anim;


	// Use this for initialization
	void Start () {
		this.runchan = runchanObj.GetComponent<Runchan>();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
