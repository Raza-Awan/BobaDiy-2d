using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    private Slider slider;
    public int colorindex = 0;
    private SceneScript scenescript;
    // Start is called before the first frame update
    void Start()
    {
        scenescript = GameObject.Find("SceneManager").GetComponent<SceneScript>();
        slider = gameObject.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        //Debug.Log("Value: " + slider.value);
        scenescript.ChangePlayercolor(colorindex, slider.value);
    }
}
