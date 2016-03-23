using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveCharacter();
	}

    void MoveCharacter()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("jump", true);
            anim.SetBool("run", false);
        }

        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("jump", false);
            anim.SetBool("run", true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("slide", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("slide", false);
        }

    }
}
