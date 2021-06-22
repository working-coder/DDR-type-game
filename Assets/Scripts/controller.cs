using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public enum Arrow
{
    UpArrow,DownArrow,RightArrow,LeftArrow
}
public class controller : MonoBehaviour
{
    private SpriteRenderer SR;
    public SpriteRenderer BoyFriendSpriteRenderer;
    public Sprite DefaultSprite;
    public Sprite pressedArrowFailed;
    public Sprite boyfriend_Unseccessful;
    public Sprite pressedArrowSuccess;
    public Sprite boyfriend_Seccessful;
    public Sprite BoyfriendDefault;

    public Arrow controolerKey;
    public KeyCode key;

    public bool setSuccesful = false;
    public bool IsTriggred = false;

    bool waitingForInputRelease = false;


    private void Start()
    {
        SR = gameObject.GetComponent<SpriteRenderer>();
        if (controolerKey == Arrow.UpArrow)
        {
            key = KeyCode.UpArrow;
        }
        else if (controolerKey == Arrow.DownArrow)
        {
            key = KeyCode.DownArrow;
        }
        else if (controolerKey == Arrow.RightArrow)
        {
            key = KeyCode.RightArrow;
        }
        else if (controolerKey == Arrow.LeftArrow)
        {
            key = KeyCode.LeftArrow;
        }
    }

    void Update()
    {
        if (IsTriggred)
        {
            if(!setSuccesful){
                SetSpriteUnsecvessful();
            }
        }
        if (!IsTriggred && !waitingForInputRelease)
        {
            if (Input.GetKey(key))
            {
                SetSpriteUnsecvessful();
            }
            else if(!Input.GetKey(key))
            {
                SetSpriteDefault();
            }
        }
        if (waitingForInputRelease)
        {
            if (Input.GetKey(key))
            {
                return;
            }
            else
            {
                waitingForInputRelease = false;
                SetSpriteDefault();
            }
        }
    }
    public void SetSpriteSuccess()
    {
        IsTriggred = false;
        SR.sprite = pressedArrowSuccess;
        BoyFriendSpriteRenderer.sprite = boyfriend_Seccessful;
        waitingForInputRelease = true;
        
    }
    public void SetSpriteUnsecvessful()
    {
        IsTriggred = false;
        SR.sprite = pressedArrowFailed;
        BoyFriendSpriteRenderer.sprite = boyfriend_Unseccessful;
        waitingForInputRelease = true;
    }
    public void SetSpriteDefault()
    {
        BoyFriendSpriteRenderer.sprite = BoyfriendDefault;
        SR.sprite = DefaultSprite;
    }
}
