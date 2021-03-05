using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bridge1Script : MonoBehaviour

{
    // Start is called before the first frame update

    public GameObject MainChar;
    public static bool bridge1Built = false;
    public string popUp;
    public GameObject gm;
    public Animator animator;
    



    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "MainChar" && bridge1Built == false)
        {
            if(GameManager.stone >= 2 && GameManager.wood >= 3)
            {
                if (Input.GetKey("e"))
                {
                    gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    print("You have collided and pressed 'e'");
                    bridge1Built = true;
                    GameManager.wood -= 4;
                    GameManager.stone -= 3;
                    animator.SetBool("bridge1", true);

                }
            }
            else
            {
                if (Input.GetKey("e"))
                {
                    PopUpSystem pop = GameObject.Find("GameManager").GetComponent<PopUpSystem>();
                    pop.PopUp(popUp);
                    print("You need more resources");
                }
               
            }
            
            
        }
        if (bridge1Built)
        {
            print("A bridge piece has been built");
        }
    }
}
