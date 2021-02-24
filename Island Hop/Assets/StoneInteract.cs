using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class StoneInteract : MonoBehaviour
    {
        public GameObject MainChar;
        public GameObject E;
        public string popUp;
        public GameObject MiningGame;


        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.name == "MainChar")
            {
                E.gameObject.SetActive(true);
                
                if (Input.GetKey("e"))
                    {
                    MiningGame.SetActive(true);
                    playerMovement.freezePlayer = true;
                    }

            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            E.gameObject.SetActive(false);
        }
    }
