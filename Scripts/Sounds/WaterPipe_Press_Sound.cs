using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPipe_Press_Sound : MonoBehaviour
{
    public static AudioSource fillDrink_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        fillDrink_AudioSource = GetComponent<AudioSource>();
    }
}
