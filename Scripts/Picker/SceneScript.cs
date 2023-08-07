using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{
    public GameObject player;
     private PlayerScript playerScript;
    private float[] colors = { 0, 0, 0 };
    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<PlayerScript>();
        Color startcolor = playerScript.GetColor();
        colors[0] = startcolor.r;
        colors[0] = startcolor.g;
        colors[0] = startcolor.b;
    }

    public void ChangePlayercolor(int rgbIndex, float colorFloat)
    {
        colors[rgbIndex] = colorFloat;
        Color temepColor = new Color(colors[0], colors[0], colors[0]);
        playerScript.SetColor(temepColor);
    }
   

}
