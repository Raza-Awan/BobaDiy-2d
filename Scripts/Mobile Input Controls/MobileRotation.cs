using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileRotation : MonoBehaviour
{
    //Rigidbody2D rb;

    //public float moveSpeed;
    //public float noInputThreshold = 0.1f; // Set a threshold to consider when there is no input.

    //float dirX;
    //float dirY;

    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the device's acceleration along the x and y axes
        float accX = Input.acceleration.x;
        float accY = Input.acceleration.y;

        // Calculate the movement direction based on the device's acceleration
        Vector2 movementDirection = new Vector2(accX, accY).normalized;

        // Move the object using the calculated movement direction and move speed
        rb.velocity = movementDirection * moveSpeed;
    }

    //private void FixedUpdate()
    //{
    //    if (Mathf.Abs(dirX) > noInputThreshold || Mathf.Abs(dirY) > noInputThreshold)
    //    {
    //        rb.velocity = new Vector2(dirX, dirY);
    //    }
    //    else
    //    {
    //        rb.velocity = Vector2.zero; // If no input, stop the object from moving.
    //    }
    //}
}
