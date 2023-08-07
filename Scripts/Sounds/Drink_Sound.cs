using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink_Sound : MonoBehaviour
{
    AudioSource drink_AudioSorce;
    public AudioClip drinkClip;

    public bool playAudio;

    // Start is called before the first frame update
    void Start()
    {
        playAudio = false;

        drink_AudioSorce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckObjectBounds.isInsideScreenBounds == false)
        {
            playAudio = true;
        }

        if (playAudio == true)
        {
            //drink_AudioSorce.PlayOneShot(drinkClip);
            drink_AudioSorce.Play();
            playAudio = false;
        }

        if (playAudio == false)
        {
            drink_AudioSorce.Stop();
        }
    }
}
