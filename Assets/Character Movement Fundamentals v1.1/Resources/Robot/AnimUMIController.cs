using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimUMIController : MonoBehaviour

{
    public Animator anim;
    public GameObject UMIModel;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            anim.SetBool("OnWalk", true);
            UMIModel.GetComponent<Animator>().Play("Armature_001_Walking");
        }
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("OnJump", true);
            UMIModel.GetComponent<Animator>().Play("Armature_001_Jump");

        }
        if (Input.GetButtonDown("Looking"))
        {
            anim.SetBool("IsLooking", true);
            UMIModel.GetComponent<Animator>().Play("Armature_001_IdleLooking");

        }

        else
                {
            anim.SetBool("isWalking", false);
        }
    }
}