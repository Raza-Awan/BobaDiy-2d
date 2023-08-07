using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Straw_Spawn_Manager : MonoBehaviour
{
    public GameObject[] straws; // Reference to the straws objects.
    public Button[] strawsButtons; // Reference to the starws buttons.

    public GameObject strawsPanel;
    public GameObject strawsPanel_Open_btn;

    public Transform spawnPoint;

    public float panelActivatDuration = 5f; // Duration in seconds before the button deactivates automatically.
    private float panelCloseTimer;

    public bool openClose_Panel;
    private bool hasInteracted;

    // Start is called before the first frame update
    void Start()
    {
        strawsPanel.SetActive(false);
        strawsPanel_Open_btn.SetActive(true);

        foreach (GameObject straw in straws)
        {
            straw.SetActive(false);
        }

        // Initialize button click events
        for (int i = 0; i < strawsButtons.Length; i++)
        {
            int index = i; // Store the index in a variable to avoid closure issues
            strawsButtons[i].onClick.AddListener(() => OnButtonClick(index));
        }

        hasInteracted = false;
        openClose_Panel = false;
    }

    // Update is called once per frame
    void Update()
    {
        PanelAutoClose();

        ManageStrawsPanel();
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

    // Method to deactivate the button.
    private void DeactivatePanel()
    {
        openClose_Panel = false;
    }


    void ManageStrawsPanel()
    {
        if (openClose_Panel == true)
        {
            strawsPanel.SetActive(true);
        }
        if (openClose_Panel == false)
        {
            strawsPanel.SetActive(false);
        }
    }

    private void OnButtonClick(int buttonIndex)
    {
        // Deactivate all objects
        for (int i = 0; i < straws.Length; i++)
        {
            straws[i].SetActive(false);
        }

        // Activate the corresponding object
        SetObjectActive(buttonIndex);

        hasInteracted = true;
        panelCloseTimer = 0f;
    }

    private void SetObjectActive(int index) 
    {
        if (index >= 0 && index < straws.Length) // for preventing null reference exception
        {
            straws[index].SetActive(true);
        }
    }

    public void OpenStrawsPanel()
    {
        openClose_Panel = !openClose_Panel;
        panelCloseTimer = 0f;
    }
    public void CloseStrawsPanel()
    {
        openClose_Panel = false;
    }
}
