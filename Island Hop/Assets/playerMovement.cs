using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
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
            }
            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                pos.y -= speed * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                pos.x += speed * Time.deltaTime;
            }
            transform.position = pos;
        }
        
        //input
            //if interactionTarget != null
                //All the wood gather things
    }
}
