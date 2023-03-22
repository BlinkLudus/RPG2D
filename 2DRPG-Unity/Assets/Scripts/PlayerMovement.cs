using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10; //The speed at which the player moves

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get horizontal input axis (Left & Right arrow keys, A/D, gamepad)
        float horizontalInput = Input.GetAxis("Horizontal");

        //Calculate players new position based on input and speed
        Vector2 newPosition = rb.position + Vector2.right * horizontalInput * speed * Time.deltaTime;

        //Set players new position
        rb.MovePosition(newPosition);
    }
}
