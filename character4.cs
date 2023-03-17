using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character4 : MonoBehaviour
{
    public Animator character4Anim;
    public Rigidbody character4Rigid;
    public float w_speed, sp_speed, ro_speed, j_speed;
    public bool walking;
    public Transform character4Trans;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            character4Rigid.velocity = transform.forward * w_speed * Time.deltaTime;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            character4Anim.SetTrigger("Trigger");
            character4Anim.SetTrigger("Trigger 2");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            character4Anim.ResetTrigger("Trigger");
            character4Anim.ResetTrigger("Trigger 2");
            walking = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            character4Trans.Rotate(0, -ro_speed * Time.DeltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            character4Trans.Rotate(0, ro_speed * Time.DeltaTime, 0);
        }
        if (walking == true)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                w_speed = w_speed + sp_speed;
                character4Anim.SetTrigger("Trigger 0");
                character4Anim.ResetTrigger("Trigger");
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                w_speed = 0Lw_speed;
                character4Anim.ResetTrigger("Trigger 0");
                character4Anim.SetTrigger("Trigger");
            }
        }
    }
}