using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sounds_manager1 : MonoBehaviour
{
    [SerializeField] Image soundOnicone;
    [SerializeField] Image soundOfficone;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.GetInt("muted", 0);
            load();
        }
        else
        {
            load();
        }
        updateicone();
        AudioListener.pause = muted;
    }
    public void onbuttonpress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
            save();
            updateicone();
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
            save();
            updateicone();
        }
    }
    private void updateicone()
    {
        if (muted == false)
        {
            soundOnicone.enabled = true;
            soundOfficone.enabled = false;

        }
        if (muted == true)
        {
            soundOnicone.enabled = false;
            soundOfficone.enabled = true;
        }
    }
    private void load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }


}
