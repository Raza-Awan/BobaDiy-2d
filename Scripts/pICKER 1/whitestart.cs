using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whitestart : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Awake()
    {
        // Get the SpriteRenderer component attached to the same GameObject.
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        // Set the SpriteRenderer's color to white.
        spriteRenderer.color = Color.white;
    }
}
