using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodcuttingGame : MonoBehaviour
{
    public enum State { In, Out, Idle}
    public State state;
    public int frameCount = 5;
    float animTimer = 0;
    public float speed;
    public string popUp;

    public Sprite[] inAnim;
    public Sprite[] outAnim;
    public Sprite[] idle;

    Image image;

    int swingCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.Idle)
        {
            image.sprite = idle[0];
            if (Input.GetKeyDown(KeyCode.D))
            {
                animTimer = 0;
                state = State.In;
                swingCounter++;
            }
        }
        
        if(state == State.In)
        {
            if (animTimer < frameCount - 1)
            {
                animTimer += Time.smoothDeltaTime * speed;
                image.sprite = inAnim[Mathf.FloorToInt(animTimer)];
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                animTimer = 0;
                state = State.Out;
            }
        }
        if (state == State.Out)
        {
            if (animTimer < frameCount - 1)
            {
                animTimer += Time.smoothDeltaTime * speed;
                image.sprite = outAnim[Mathf.FloorToInt(animTimer)];
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                animTimer = 0;
                state = State.In;
                swingCounter++;
            }
        }
        if (swingCounter >= 3 && frameCount-1<animTimer)
        {
            swingCounter = 0;
            PopUpSystem pop = GameObject.Find("GameManager").GetComponent<PopUpSystem>();
            pop.PopUp(popUp);
            this.gameObject.SetActive(false);
            GameManager.wood++;
            playerMovement.freezePlayer = false;
            state = State.Idle;
        }
    }
}
