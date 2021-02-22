using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MainChar;
    public GameObject E;
    public int wood = 0;
    public int stone = 0;
    public Text woodText;

    // Start is called before the first frame update
    void Start()
    {
        E.gameObject.SetActive(false);
        wood++;
        print(wood);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
