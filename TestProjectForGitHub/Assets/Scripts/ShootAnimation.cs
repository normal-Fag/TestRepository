using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAnimation : MonoBehaviour
{
    Animator weapon;
    playerMovement velocity = new playerMovement();

    // Start is called before the first frame update
    void Start()
    {
        weapon = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var animState = weapon.GetCurrentAnimatorStateInfo(0);

        if (Input.GetButtonDown("Fire1") && Checkanimation(animState))
        {
            weapon.SetTrigger("MouseFire1");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            weapon.SetTrigger("Reload");
        }

        if(velocity.controller.velocity.x != 0)
        {
            weapon.SetBool("isRunning", true);
        }

    }

    public bool Checkanimation(AnimatorStateInfo animState)
    {
        if (animState.IsName("idlePistol"))
        {
            return true;
        }

        return false;
    }
}
