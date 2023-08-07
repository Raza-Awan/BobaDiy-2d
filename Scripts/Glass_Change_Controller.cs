using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass_Change_Controller : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Reference to the objects you want to control.

    public GameObject glassChangePanel;
    public GameObject glassChangePanel_OpenBtn;
    public GameObject colorPicker_OnOff;

    private GameObject objectToActivate; // Reference to the button object you want to activate.

    private float panelCloseTimer;
    public float panelActivatDuration = 5f; // Duration in seconds before the button deactivates automatically.

    public bool openClose_Panel;
    private bool hasInteracted;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate = glassChangePanel;

        // Initially, activate the first object and deactivate others.
        ChangeGlass(0);

        glassChangePanel.SetActive(false);
        glassChangePanel_OpenBtn.SetActive(true);

        openClose_Panel = false;
        hasInteracted = false;
    }

    // Update is called once per frame
    void Update()
    {
        PanelAutoClose();
        ManageGlassChangePanel();
    }

    // Method to activate the selected object and deactivate others.
    public void ChangeGlass(int objectIndex)
    {
        if (objectIndex < 0 || objectIndex >= objectsToActivate.Length)
        {
            Debug.LogError("Invalid object index.");
            return;
        }

        // Check for specific objects with tags and destroy them if found before changing the glass.
        DestroyObjectsWithTag("FeatureObjects");

        // Set the selected object active and deactivate others.
        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(i == objectIndex);
        }

        hasInteracted = true;
        panelCloseTimer = 0f;
    }

    // Method to destroy objects with a specific tag.
    private void DestroyObjectsWithTag(string tag)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
        foreach (var obj in objectsWithTag)
        {
            Destroy(obj);
        }
    }

    private void PanelAutoClose()
    {
        // Check if the button is active and not interacted with.
        if (openClose_Panel == true && hasInteracted == false)
        {
            // Increment the timer.
            panelCloseTimer += Time.deltaTime;

            // Check if the timer has exceeded the activation duration.
            if (panelCloseTimer >= panelActivatDuration)
            {
                // Deactivate the button.
                DeactivatePanel();
            }
        }

        if (hasInteracted == true)
        {
            hasInteracted = false;
        }
    }

    private void DeactivatePanel()
    {
        openClose_Panel = false;
    }

    void ManageGlassChangePanel()
    {
        if (openClose_Panel == true)
        {
            glassChangePanel.SetActive(true);
            colorPicker_OnOff.SetActive(true);
            //glassChangePanel_OpenBtn.SetActive(false);
        }
        if (openClose_Panel == false)
        {
            glassChangePanel.SetActive(false);
            colorPicker_OnOff.SetActive(false);
            //glassChangePanel_OpenBtn.SetActive(true);
        }
    }

    public void OpenGlassChangePanel()
    {
        openClose_Panel = !openClose_Panel;
        panelCloseTimer = 0f;
    }
    public void CloseGlassChangePanel()
    {
        openClose_Panel = false;
    }
}
