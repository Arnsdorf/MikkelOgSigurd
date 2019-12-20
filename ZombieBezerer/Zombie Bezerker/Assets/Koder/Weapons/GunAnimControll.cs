using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimControll : MonoBehaviour
{
    private Animator anim;
    public Rigidbody rig;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    //--------------------------------------------------------------------mechanics and triggers---------------------------------------------------
    void Update()
    {
        if (anim == null) return;
        if (anim == null) Debug.Log("Mikkel Please add more animations");


        if (rig.velocity.magnitude != 0)
        {
            anim.Play("AKM_Walking");
        }
        else if (rig.velocity.magnitude < 2)
        {
            anim.Play("AKM_Idle");
        }
        if (Input.GetKeyUp(KeyCode.R)) // if r is pressed, reload
        {
            anim.Play("AKM_Realoading");
        }
        if (Input.GetMouseButtonDown(0)) //if mouse press, shoot
        {
            anim.Play("AKM_Shooting");
        }
    }
}