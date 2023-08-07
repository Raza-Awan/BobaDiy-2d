using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObjectBounds : MonoBehaviour
{
    public static bool isInsideScreenBounds;

    // Update is called once per frame
    void Update()
    {
        CheckIfObjectInsideScreenBounds();
    }

    void CheckIfObjectInsideScreenBounds()
    {
        if (this.gameObject.activeSelf == true)
        {
            Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);

            // Check if the object is inside the screen bounds
            if (viewportPos.x >= 0 && viewportPos.x <= 1 && viewportPos.y >= 0 && viewportPos.y <= 1)
            {
                isInsideScreenBounds = true;
            }
            else
            {
                isInsideScreenBounds = false;
            }
        }
    }

    // Optionally, you can use this method to retrieve the result from other scripts
    public bool IsInsideScreenBounds()
    {
        return isInsideScreenBounds;
    }
}
