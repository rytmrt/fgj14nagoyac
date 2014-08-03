using UnityEngine;
using System.Collections;

public class Runchan : MonoBehaviour {

	const float START_POS_X = 51.0f;

	public float initialSpeed = 1.0f;
	public float speed = 1.0f;
	public float speedRate = 1.0f;
	public float jumpForce = 2.0f;
	public int floorNum = 0;
	public int initialDirection = 0;
	public int life = 3;
	public AudioClip jumpSE;

	private AudioSource jumpSeSource;
	private Animator anim;
	private Vector3 direction = Vector3.left;
	private bool isJump = false;

	private bool nextflag = false;

	// Use this for initialization
	void Start () {
		this.anim = GetComponent( "Animator" ) as Animator;

		this.InitPlayer ();
	}
	
	// Update is called once per frame
	void Update () {
		this.isJump = this.anim.GetBool("isJump");

		this.UpdateMove ();
		this.UpdateCameraPos ();
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "Floor") {
			JumpEnd();
		}
		if (coll.gameObject.name == "End") {
			this.Stop ();
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.name == "wepon") {
			this.Damage();
			Destroy(coll.gameObject);
		}
	}

	public int GetDirection () {
		if (this.direction == Vector3.left) return 1;
		if (this.direction == Vector3.right) return 0;
		return -1;
	}

	public void changeDoragonToggle () {
		bool doragon = this.anim.GetBool("doragon");
		this.anim.SetBool("doragon", !doragon);
	}

	public void changeEbiToggle () {
		bool flag = this.anim.GetBool("ebi");
		this.anim.SetBool("ebi", !flag);
	}

	public void NextFloor (){
		this.floorNum++;
		this.initialDirection = this.GetDirection() == 0 ? 1 : 0;
		this.InitPlayer();
	}

	// private methods ---------------------------------
	private void InitPlayer () {
		if (this.initialDirection == 0) { // run right
			this.direction = Vector3.right;
		}
		else if (this.initialDirection == 1) { // run left
			this.direction = Vector3.left;
		}

		this.anim.SetBool("isStandby", false);

		var pos = this.transform.position;
		pos.x = (this.initialDirection == 0 ? -1.0f : 1.0f) * Runchan.START_POS_X;
		pos.y = this.floorNum * (6.4f);
		this.transform.position = pos;

		var scale = this.transform.localScale;
		scale.x = Mathf.Abs(scale.x) * (this.initialDirection == 0 ? -1.0f : 1.0f); 
		this.transform.localScale = scale;

		this.speed = floorNum * 0.2f + initialSpeed;
		this.nextflag = false;
	}

	private void UpdateCameraPos() {
		var cpos = Camera.main.transform.position;
		cpos.x = this.transform.position.x - ((this.GetDirection() == 0 ? -1.0f : 1.0f) * 2.5f);
		cpos.y = this.floorNum * (6.4f);
		Camera.main.transform.position =  Vector3.Lerp(Camera.main.transform.position, cpos, 10f * Time.deltaTime);
	}

	private void UpdateMove () {
		this.Move ();
		if (!nextflag && Input.GetMouseButtonUp(0)) {
			this.Jump ();
		}
	}

	private void Move () {
		var pos = transform.position;
		pos = (this.direction * (this.speed * 0.1f));
		this.transform.Translate (pos);
	}

	private void Jump () {
		if (!this.isJump) {
			this.anim.SetBool("isJump", true);
			rigidbody2D.AddForce(Vector2.up * (450 * this.jumpForce));
		}
	}

	private void JumpEnd () {
		this.anim.SetBool("isJump", false);
	}

	private void Stop (){
		this.speed = 0;
		this.anim.SetBool("isStandby", true);
		this.nextflag = true;
	}

	private void Damage () {
		this.life --;
		Debug.Log(this.life);
	}
}
