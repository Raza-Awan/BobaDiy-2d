using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileCameraManager : MonoBehaviour
{
    public RawImage background; // for displaying camera preview in game on this image
    public AspectRatioFitter fit; // for adjusting display according to mobiles aspect ratio

    private bool camAvalaible; // check if camera is avalaible or not
    private WebCamTexture backCam; // cam which you want to display 
    private Texture defaultBackground; // for going back to original background 


    // Start is called before the first frame update
    void Start()
    {
        defaultBackground = background.texture;
        //camAvalaible = false;
        CameraHandler();
    }

    private void CameraHandler()
    {
        WebCamDevice[] devices = WebCamTexture.devices; // for searching camera devices on our mobile device

        if (devices.Length == 0) // means our mobile device have no camera 
        {
            Debug.Log("No Camera detected!!");
            camAvalaible = false;
            return;
        }

        // Incase we have camera or cameras in our mobile device
        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing == false) // means camera other than front camera, which will be back camera by default
            {
                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height); // set our back cam texture to the back Camera  
            }
        }

        if (backCam == null) // a check in case back camera of mobile is not found
        {
            Debug.Log("Back Camera not found");
            return;
        }

        backCam.Play(); // for playing whatever is our mobile's back camera is seeing
        background.texture = backCam; // for // for rendering/displaying whatever is our mobile's back camera is seeing on background texture

        camAvalaible = true; // setting it true will allow is to render back cam ever single frame in update
    }

    // Update is called once per frame
    void Update()
    {
        if (camAvalaible == false)
        {
            return;
        }

        //if (camAvalaible == true)
        //{
        //    CameraHandler();
        //}

        float ratio = (float)backCam.width / (float)backCam.height; // here casting float will increase the precesion, and give a good estimate of mobile aspect ratio
        fit.aspectRatio = ratio;

        float scaleY = backCam.videoVerticallyMirrored ? -1f : 1f; // checking if somehow our video or screen is mirrored 
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f); // if screen was mirrored than it will invert it in y axis

        int orientation = -backCam.videoRotationAngle; // for keeping track of rotation of mobile back cam
        background.rectTransform.localEulerAngles = new Vector3(0f, 0f, orientation);
    }

    public void CameraOnOff()
    {
        camAvalaible = !camAvalaible;
    }
}
