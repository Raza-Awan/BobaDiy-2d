using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBuffet : MonoBehaviour
{
    public Transform initialPos;
    public Transform targetPos;
    public GameObject objectToMove;

    public float speed = 200f;

    public bool loop;

    void Update()
    {
        Vector3 targetPosition = targetPos.position;
        float step = speed * Time.deltaTime;

        // Move the object towards the target position using MoveTowards
        objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition, step);

        // Check if the object has reached the target position
        if (objectToMove.transform.position == targetPosition)
        {
            objectToMove.SetActive(false);
            // If loop is true, reset the object's position to the initial position
            if (loop)
            {
                objectToMove.SetActive(true);
                objectToMove.transform.position = initialPos.position;

            }
        }
    }
}
