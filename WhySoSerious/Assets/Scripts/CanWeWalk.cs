using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanWeWalk : MonoBehaviour {

    Animator anim;
    int walk = Animator.StringToHash("Walk");
    int stand = Animator.StringToHash("Base Layer.Standing@loop");


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Vertical");
        anim.SetFloat("WalkSpeed", move);

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("Walk", true);
            anim.SetTrigger(walk);
            //anim.Play("Walking@loop");
        }
	}

   /* void OnAnimatorMove()
    {
        Animator animator = GetComponent<Animator>();
        if (animator)
        {
            Vector3 newPosition = transform.position;
            newPosition.z += animator.GetFloat("Runspeed") * Time.deltaTime;
            transform.position = newPosition;
        }
    }*/
}
