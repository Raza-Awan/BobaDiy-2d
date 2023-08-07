using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Color_Controller : MonoBehaviour
{
    public Material[] fluidMaterials; // assign ref in editor
    public SpriteRenderer[] waterPipesColors;  // assign ref in editor
    public Color[] colors;  // assign ref in editor


    private void Start()
    {
        for (int i = 0; i < fluidMaterials.Length; i++)
        {
            fluidMaterials[i].color = colors[i];
            waterPipesColors[i].color = colors[i];
        }
    }
}
