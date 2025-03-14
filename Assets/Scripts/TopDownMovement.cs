using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        moveInput.y = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;
    }
}