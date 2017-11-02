using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanWeWalk2 : MonoBehaviour {

	Animator anim;
	int walk = Animator.StringToHash("Walking");
	int stand = Animator.StringToHash("Base Layer.Idle");


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis("Vertical");
		anim.SetFloat("WalkSpeed", move);

		AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
		{
			anim.SetBool("Walk", true);
			anim.SetTrigger(walk);
		}

		else
		{
			anim.SetBool("Walk", false);
			anim.SetTrigger(stand);
		}
	}
}
