using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MainChar;
    public GameObject E;
    public GameObject WoodcuttingGame;
    public GameObject MiningGame;
    public static int wood = 0;
    public static int stone = 0;
    public Text woodText;
    public Text stoneText;

    // Start is called before the first frame update
    void Start()
    {
        E.gameObject.SetActive(false);
        WoodcuttingGame.SetActive(false);
        MiningGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (bridge1Script.bridge1Built)
        {
            stoneText.text = "" + stone;
            woodText.text = "" + wood;
        }
        if (bridge2Script.bridge2Built)
        {
            stoneText.text = "" + stone;
            woodText.text = "" + wood;
        }

        if (Input.GetKeyDown("1"))
        {
            wood++;
            woodText.text = "" + wood;
        }
        if (Input.GetKeyDown("2"))
        {
            stone++;
            stoneText.text = "" + stone;
        }
    }

    public void UpdateUI()
    {
        stoneText.text = "" + stone;
        woodText.text = "" + wood;
    }
}
