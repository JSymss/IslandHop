using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge2Script : MonoBehaviour

{
    // Start is called before the first frame update

    public GameObject MainChar;
    bool bridge2Built = false;
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "MainChar" && bridge2Built == false)
        {
            if (GameManager.stone > 2 && GameManager.wood > 3)
            {
                if (Input.GetKeyDown("e"))
                {
                    gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    print("You have collided and pressed 'e'");
                    gameObject.GetComponent<Renderer>().enabled = true;
                    bridge2Built = true;
                    GameManager.wood -= 4;
                    GameManager.stone -= 3;
                }
            }
            else
            {
                print("You need more resources");
            }


        }
        if (bridge2Built)
        {
            print("A bridge piece has been built");
        }
    }
}
