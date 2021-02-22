using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MainChar;
    public GameObject E;
    public static int wood = 0;
    public static int stone = 0;
    public Text woodText;
    public Text stoneText;

    // Start is called before the first frame update
    void Start()
    {
        E.gameObject.SetActive(false);
        print(wood);
    }

    // Update is called once per frame
    void Update()
    {
        
        woodText.text = ""+wood;
        if (Input.GetKeyDown("1"))
        {
            wood++;
        }
        stoneText.text = ""+stone;
        if (Input.GetKeyDown("2"))
        {
            stone++;
        }
    }
}
