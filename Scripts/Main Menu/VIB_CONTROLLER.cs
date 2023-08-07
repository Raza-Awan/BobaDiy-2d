using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIB_CONTROLLER : MonoBehaviour
{
    public GameObject vib_on;
    public GameObject vib_off;
    public static int vib = 0;
    // Start is called before the first frame update
    void Start()
    {
        vib = PlayerPrefs.GetInt("vib", +vib);
    }

    // Update is called once per frame
    void Update()
    {
        vib = PlayerPrefs.GetInt("vib", +vib);
        if(vib == 0)
        {
            vib_on.SetActive(true);
            vib_off.SetActive(false);
        }
        if (vib == 1)
        {
            vib_on.SetActive(false);
            vib_off.SetActive(true);
        }
    }
    public void vibration_press()
    {
        vib = PlayerPrefs.GetInt("vib", +vib);
        if(vib == 0)
        {
            vib = 1;
            
        }else
        {
            vib = 0;
        }
        PlayerPrefs.SetInt("vib", +vib);
    }
}
