using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed = 7.5f;
    public static bool freezePlayer = false;
    //gameobject interactiontarget

    // Update is called once per frame
    void Update()
    {
        if (freezePlayer == false)
        {
            Vector3 pos = transform.position;

            if (Input.GetKey("w"))
            {
                pos.y += speed * Time.deltaTime;
                animator.SetBool("Up", true);
            }
            else
            {
                animator.SetBool("Up", false);
            }


            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
                animator.SetBool("Left", true);


            }

            else
            {
                animator.SetBool("Left", false);

            }


            if (Input.GetKey("s"))
            {
                pos.y -= speed * Time.deltaTime;
                animator.SetBool("Down", true);

            }

            else
            {
                animator.SetBool("Down", false);
            }


            if (Input.GetKey("d"))
            {
                pos.x += speed * Time.deltaTime;
                animator.SetBool("Right", true);

            }
            else
            {
                animator.SetBool("Right", false);
            }
            transform.position = pos;
        }
        
        //input
            //if interactionTarget != null
                //All the wood gather things
    }
}
