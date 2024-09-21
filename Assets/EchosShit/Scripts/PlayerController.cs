using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float playerWalkSpeed;
    [SerializeField] float playerRunSpeed;
    [SerializeField] Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce((Vector2.up * Input.GetAxisRaw("Vertical") + Vector2.right * Input.GetAxisRaw("Horizontal")).normalized * playerRunSpeed * (1000));
        }
        else
        {
            rb.AddForce((Vector2.up * Input.GetAxisRaw("Vertical") + Vector2.right * Input.GetAxisRaw("Horizontal")).normalized * playerWalkSpeed * (1000));
        }
    }
}
