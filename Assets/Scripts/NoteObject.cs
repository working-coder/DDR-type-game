using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed = false;
    public float pointsAdd = 100;
    public controller controller;
    public pointsManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(controller.key)&& canBePressed)
        {
            controller.SetSpriteSuccess();
            controller.setSuccesful = true;
            gameObject.SetActive(false);
            manager.points += pointsAdd;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            collision.GetComponent<controller>().IsTriggred = true;
            canBePressed = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}
