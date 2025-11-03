using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = transform.position;
        Position.x = Position.x + 0.01f;
        transform.position = Position;
        Vector2 Positio = transform.position;
        Positio.y = Positio.y + 0.01f;
        transform.position = Positio;
        float horizontal = 0.0f;
        if (Keyboard.current.aKey.isPressed)
        {
        horizontal = -1.0f;
            if (Keyboard.current.dKey.isPressed)
            {
        horizontal = 1.0f;
        }
    }
}
