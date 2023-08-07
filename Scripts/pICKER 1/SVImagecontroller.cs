using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SVImagecontroller : MonoBehaviour,IDragHandler,IPointerClickHandler 
{
    [SerializeField]
    private RawImage pickerImage;

    private RawImage SVimage;

    private Colourpickercontroller cc;
    private RectTransform rectTransform, pickerTransform;

    /*
        private void Awake()
        {
            SVimage = GetComponent<RawImage>();
            cc = FindObjectOfType<Colourpickercontroller>();
            rectTransform = GetComponent<RectTransform>();

            pickerTransform = pickerImage.GetComponent<RectTransform>();
             pickerTransform.position = new Vector2((rectTransform.sizeDelta.x * 5f), (rectTransform.sizeDelta.y * 5f));
        }


        void UpdateColour(PointerEventData eventData)
        {
            Vector3 pos = rectTransform.InverseTransformPoint(eventData.position);

            float deltaX = rectTransform.sizeDelta.x * 0.5f;
            float deltaY = rectTransform.sizeDelta.y * 0.5f;

            if(pos.x < -deltaX)
            {
                pos.x = -deltaX;
            }
            else if (pos.x > deltaX)
            {
                pos.x = deltaX;
            }
            if (pos.y < -deltaY)
            {
                pos.y = -deltaY;
            }
            else if (pos.y > deltaY)
            {
                pos.y = deltaY;
            }

            float x = pos.x + deltaX;
            float y = pos.y + deltaY;

            float xNorm = x / rectTransform.sizeDelta.x;
            float yNorm = y / rectTransform.sizeDelta.y;

            pickerTransform.localPosition = pos;
            pickerImage.color = Color.HSVToRGB(0, 0, 1 - yNorm);

            cc.setSV(xNorm, yNorm);


        }
        public void OnDrag(PointerEventData eventData)
        {
            UpdateColour(eventData);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            UpdateColour(eventData);
        }*/
    private void Awake()
    {
        SVimage = GetComponent<RawImage>();
        cc = FindObjectOfType<Colourpickercontroller>();
        rectTransform = GetComponent<RectTransform>();
        pickerTransform = pickerImage.GetComponent<RectTransform>();

        // Set the initial color (e.g., fully saturated red).
        float initialHue = 1f; // 0 for red, 0.3333 for green, 0.6666 for blue.
        float initialSaturation = 0f; // 0 to 1, where 0 is grayscale and 1 is fully saturated.
        float initialValue = 0f; // 0 to 1, where 0 is black and 1 is fully bright.

        // Update the color of the pickerImage and the Colourpickercontroller.
        UpdateColourWithInitialColor(initialHue, initialSaturation, initialValue);
    }

    void UpdateColour(PointerEventData eventData)
    {
        Vector3 pos = rectTransform.InverseTransformPoint(eventData.position);

        float deltaX = rectTransform.sizeDelta.x * 1f;
        float deltaY = rectTransform.sizeDelta.y * 1f;

        if (pos.x < -deltaX)
        {
            pos.x = -deltaX;
        }
        else if (pos.x > deltaX)
        {
            pos.x = deltaX;
        }
        if (pos.y < -deltaY)
        {
            pos.y = -deltaY;
        }
        else if (pos.y > deltaY)
        {
            pos.y = deltaY;
        }

        float x = pos.x + deltaX;
        float y = pos.y + deltaY;

        float xNorm = x / rectTransform.sizeDelta.x;
        float yNorm = y / rectTransform.sizeDelta.y;

        pickerTransform.localPosition = pos;
        pickerImage.color = Color.HSVToRGB(0, 0, 1 - yNorm);

        cc.setSV(xNorm, yNorm);
    }

    public void OnDrag(PointerEventData eventData)
    {
        UpdateColour(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        UpdateColour(eventData);
    }

    void UpdateColourWithInitialColor(float hue, float saturation, float value)
    {
        
        float xNorm = hue;
        float yNorm = 1f - saturation;

        // Calculate the position in the RectTransform.
        float deltaX = rectTransform.sizeDelta.x * 0.5f;
        float deltaY = rectTransform.sizeDelta.y * 0.5f;
        float x = xNorm * rectTransform.sizeDelta.x - deltaX;
        float y = yNorm * rectTransform.sizeDelta.y - deltaY;

        // Set the position of the pickerImage.
        pickerTransform.localPosition = new Vector2(x, y);

        pickerImage.color = Color.HSVToRGB(0, 0, 1 - yNorm);

        cc.setSV(xNorm, yNorm);
    }
}
