using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_on_off : MonoBehaviour
{
    public GameObject background;
    public GameObject camera_image;
    public GameObject camera_panel;
    public bool cam_on= false;
    public bool cam_panel= false;

    public float cam_panel_timer;

    
    // Start is called before the first frame update
    void Start()
    {
        cam_on = false;
        cam_panel = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cam_on == true)
        {
            camera_image.SetActive(true);
            background.SetActive(false);
        }
        if (cam_on == false)
        {
            camera_image.SetActive(false);
            background.SetActive(true);
        }
        if (cam_panel == true)
        {
            camera_panel.SetActive(true);
            cam_panel_timer += 1 * Time.deltaTime;
        }
        if (cam_panel == false)
        {
            camera_panel.SetActive(false);
        }
        if(cam_panel_timer >= 5)
        {
            cam_panel_timer = 0;
            cam_panel = false;
        }
    }
    public void cam_on_butt()
    {
        cam_on = true;
    }
    public void cam_off_butt()
    {
        cam_on = false;
    }

    public void cam_panel_butt_on()
    {
        cam_panel = true;
    }
    public void cam_panel_butt_off()
    {
        cam_panel = false;
    }
}
