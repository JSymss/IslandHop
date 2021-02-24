using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeInteract : MonoBehaviour
{
    public GameObject MainChar;
    public GameObject E;
    public GameObject WoodcuttingGame;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.name == "MainChar")
        {
            //collision.gameobject.GetComponent<Player>().interactionTarget = this.gameobject
            E.gameObject.SetActive(true);
            if (Input.GetKey("e"))
            {
                print("You have collided and pressed 'e'");
                WoodcuttingGame.SetActive(true);
                playerMovement.freezePlayer = true;
                //MainChar.GetComponent<playerMovement>().enabled = true;

            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        E.gameObject.SetActive(false);
        //collision.gameobject.GetComponent<Player>().interactionTarget = null
    }
}
