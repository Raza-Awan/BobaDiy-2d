using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    public Slider _slider;
    public float timer = 0;
    /*public static bool load = true;

    public Text load_text;
    public int load_count = 0;

    public int first_time_load= 0;*/
    // Start is called before the first frame update
    void Start()
    {
       // Character_Holder.currentCharacterIndex = PlayerPrefs.GetInt("currentCharacterIndex", Character_Holder.currentCharacterIndex);
        //first_time_load = 0;
       // PlayerPrefs.SetInt("first_time_load", +first_time_load);
      //  first_time_load = PlayerPrefs.GetInt("first_time_load", +first_time_load);
        //load = true;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        _slider.value = timer / 5;
        /*load_text.text = load_count.ToString("0");

        if(timer > 0 && timer < 0.5)
        {
            load_count = 15;
        }
        if (timer > 1 && timer < 2)
        {
            load_count = 34;
        }
        if (timer > 2 && timer < 2.5)
        {
            load_count = 35;
        }
        if (timer > 2 && timer < 3)
        {
            load_count = 47;
        }
        if (timer > 3 && timer < 3.5)
        {
            load_count = 62;
        }
        if (timer > 3.5 && timer < 4)
        {
            load_count = 74;
        }
        if (timer > 4 && timer < 5)
        {
            load_count = 90;
        }
        if (timer > 5 )
        {
            load_count = 100;
        }
        if (load == true)
        {
            timer += 1 * Time.deltaTime;
            _slider.value = timer / 5;
            if (timer >= 5)
            {
                load = false;
                main_menu();
            }
        }*/
        if (timer >= 6)
        {
            main_menu();
        }
    }
    public void main_menu()
    {/*
        first_time_load = PlayerPrefs.GetInt("first_time_load", +first_time_load);
        if (first_time_load == 0)
        {
            SceneManager.LoadScene(1);
            first_time_load = 1;
            PlayerPrefs.SetInt("first_time_load", +first_time_load);

        }
        else 
        {
            SceneManager.LoadScene(1);
        }*/
        SceneManager.LoadScene(1);
    }

}
