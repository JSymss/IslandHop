﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge1Script : MonoBehaviour

{
    // Start is called before the first frame update

    public GameObject MainChar;
    bool bridge1Built = false;
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "MainChar")
        {
            
            if (Input.GetKeyDown("e"))
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                print("You have collided and pressed 'e'");
                gameObject.GetComponent<Renderer>().enabled = true;
                bridge1Built = true;
            }
        }
        if (bridge1Built)
        {
            print("A bridge piece has been built");
        }
    }
}
