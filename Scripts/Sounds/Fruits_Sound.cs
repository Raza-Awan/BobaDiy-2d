using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits_Sound : MonoBehaviour
{
    AudioSource drop_topping_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        drop_topping_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Glass"))
        {
            drop_topping_AudioSource.Play();
        }
    }
}
