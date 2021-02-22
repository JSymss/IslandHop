using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeInteract : MonoBehaviour
{
    public GameObject MainChar;
    public GameObject E;
    public string popUp;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.name == "MainChar")
        {
            E.gameObject.SetActive(true);
            if (Input.GetKeyDown("e"))
            {
                print("You have collided and pressed 'e'");
                MainChar.GetComponent<playerMovement>().enabled = true;
                PopUpSystem pop = GameObject.Find("GameManager").GetComponent<PopUpSystem>();
                pop.PopUp(popUp);
                GameManager.wood += 1;

            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        E.gameObject.SetActive(false);
    }
}
