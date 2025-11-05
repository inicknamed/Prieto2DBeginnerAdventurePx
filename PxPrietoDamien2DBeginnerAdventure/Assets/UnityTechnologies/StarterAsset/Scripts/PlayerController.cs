using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
    
{
    public InputAction LeftAction;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //---------------------------------------------- 
        float horizontal = 0.0f;
        float vertical = 0.0f;
     

        //tickle
        //keys
        if (Keyboard.current.aKey.isPressed)
        {
            horizontal = -1.0f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            horizontal = 1.0f;
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            horizontal = 1.0f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            vertical = -1.0f;
        }
        if (Keyboard.current.wKey.isPressed)
        {
            vertical = 1.0f;
        }


        Debug.Log(horizontal);
        //--------------------------------

        Vector2 Position = transform.position;
        Position.x = Position.x + 0.01f * horizontal;
        transform.position = Position;
        Vector2 Positio = transform.position;
        Positio.y = Positio.y + 0.01f * vertical;
        transform.position = Positio;
        //
    }
}
