using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Projectiles : MonoBehaviour
{
    Rigidbody2D rigidbody2d;



    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Lauch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Projectile Collison with " + other.gameObject);
        Destroy(gameObject);
    }
}
