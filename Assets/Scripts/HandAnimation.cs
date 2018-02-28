using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour {

    private Animator _anim;
    private HandGrabbing _handGrab;

	// Use this for initialization
	void Start ()
    {
        _anim = GetComponentInChildren<Animator>();
        _handGrab = GetComponent<HandGrabbing>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		//if we are pressing grab, set animator bool IsGrabbing to true
        if(Input.GetAxis(_handGrab.InputName) >= 0.01f)
        {
            if (!_anim.GetBool("IsGrabbing"))
            {
                _anim.SetBool("IsGrabbing", true);
            }
        }
        else
        {
            //if we let go of grab, set IsGrabbing to false
            if(_anim.GetBool("IsGrabbing"))
            {
                _anim.SetBool("IsGrabbing", false);
            }
        }

	}
}
