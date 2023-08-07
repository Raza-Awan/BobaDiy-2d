using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot_controller : MonoBehaviour
{
    public GameObject[] dot;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if(timer < 0.3)
        {
            dot[0].SetActive(false);
            dot[1].SetActive(false);
            dot[2].SetActive(false);
        }
        if (timer > 0.3)
        {
            dot[0].SetActive(true);
        }
        if (timer > 0.6)
        {
            dot[0].SetActive(true);
            dot[1].SetActive(true);
        }
        if (timer > 0.9)
        {
            dot[0].SetActive(true);
            dot[1].SetActive(true);
            dot[2].SetActive(true);
        }
        if (timer > 1.2)
        {
            timer = 0;
        }
    }
}
