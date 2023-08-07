using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Colourpickercontroller : MonoBehaviour
{
    public float currentHue, currentsat=1, currentVal=1;
    [SerializeField]
    private RawImage hueImage, satValImage;
    
    [SerializeField]
    private Slider hueSlider;

    private Texture2D hueTexture, svTexture, outputTexture;
/* [SerializeField]
    MeshRenderer changethiscolour;*/

    [SerializeField]
   SpriteRenderer[] glass;

    private void Start()
    {
        createHueImage();

        CreateSVImage();

        // CreateOutputImage();
        
        UpdateOutputImage();
        for (int i = 0; i < glass.Length; i++)
        {
            glass[i].color = Color.white;
        }
    }
   
    private void Update()
    {
        currentsat = 1;
        currentVal = 1;
    }
    private void createHueImage()
    {
        hueTexture = new Texture2D(1, 16);
        hueTexture.wrapMode = TextureWrapMode.Clamp;
        hueTexture.name = "HueTexture";

        for(int i = 0; i < hueTexture.height; i++)
        {
            hueTexture.SetPixel(0, i, Color.HSVToRGB((float)i / hueTexture.height, 1, 2f));

        }

        hueTexture.Apply();
        currentHue = 0;

        hueImage.texture = hueTexture;
    }

   private void CreateSVImage()
    {  
        svTexture = new Texture2D(16, 16);
        svTexture.wrapMode = TextureWrapMode.Clamp;
        svTexture.name = "SatValTexture";

        for(int y = 0; y < svTexture.height; y++)
        {
            for (int x = 0; x< svTexture.width; x++)
            {
                svTexture.SetPixel(x, y, Color.HSVToRGB(
                    currentHue,
                    (float)x / svTexture.width,
                    (float)y / svTexture.height));
            }
        }
        svTexture.Apply();
        currentsat = 0;
        currentVal = 0;

        satValImage.texture = svTexture;

    }

    /* private void CreateOutputImage()
     {
         outputTexture = new Texture2D(1, 16);
         outputTexture.wrapMode = TextureWrapMode.Clamp;
         outputTexture.name = "OutputTexture";

         Color currentColour = Color.HSVToRGB(currentHue, currentsat, currentVal);

         for (int i = 0; i < outputTexture.height; i++)
             {
             outputTexture.SetPixel(0, i, currentColour);
         }

         outputTexture.Apply();

        // outputImage.texture = outputTexture;
     }*/

    public void UpdateOutputImage()
    {
        Color currentColour = Color.HSVToRGB(currentHue, currentsat, currentVal);
        /*
        for (int i = 0; i < outputTexture.height; i++)
        {
            outputTexture.SetPixel(0, i, currentColour);
        }
        
        outputTexture.Apply();
         //changethiscolour.material.SetColor("_BaseColor", currentColour);
        changethiscolour.GetComponent<MeshRenderer>().material.color = currentColour;*/
        for (int i = 0; i < glass.Length; i++)
        {
            glass[i].GetComponent<SpriteRenderer>().color = currentColour;
        }
    }
    public void setSV(float S, float V)
    {
        currentsat = S;
        currentVal = V;
        UpdateOutputImage();
    }
    public void UpdateSVimage()
    {
        currentHue = hueSlider.value;

        for(int y = 0; y < svTexture.height; y++)
        {
            for(int x = 0; x < svTexture.width;x++)
            {
                svTexture.SetPixel(x, y, Color.HSVToRGB(
                    currentHue,
                    (float)x / svTexture.width,
                    (float)y / svTexture.height));
            }
            svTexture.Apply();
            UpdateOutputImage();
            
        }
    }
}
