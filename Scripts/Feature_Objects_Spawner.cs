using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feature_Objects_Spawner : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Reference to the prefabs of the fruits objects.

    public GameObject featureOjectsPanel;
    public GameObject featureOjectsPanel_OpenBtn;

    private GameObject objectToActivate; // Reference to the button object you want to activate.

    public Transform spawnPoint;

    public float minX;
    public float maxX;
    public float panelActivatDuration = 5f; // Duration in seconds before the button deactivates automatically.
    private float panelCloseTimer;

    public bool openClose_Panel;
    private bool hasInteracted;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate = featureOjectsPanel;

        featureOjectsPanel.SetActive(false);
        featureOjectsPanel_OpenBtn.SetActive(true);

        hasInteracted = false;
        openClose_Panel = false;
    }

    // Update is called once per frame
    void Update()
    {
        PanelAutoClose();

        ManageFeatureObjectsPanel();
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


    void ManageFeatureObjectsPanel()
    {
        if (openClose_Panel == true)
        {
            featureOjectsPanel.SetActive(true);
            //featureOjectsPanel_OpenBtn.SetActive(false);
        }
        if (openClose_Panel == false)
        {
            featureOjectsPanel.SetActive(false);
            //featureOjectsPanel_OpenBtn.SetActive(true);
        }
    }

    // Method to instantiate the selected object.
    public void InstantiateObject(int objectIndex)
    {
        if (objectIndex < 0 || objectIndex >= objectPrefabs.Length)
        {
            Debug.LogError("Invalid object index.");
            return;
        }

        float RandomX = Random.Range(minX, maxX);

        // Instantiate the selected object prefab.
        Instantiate(objectPrefabs[objectIndex], new Vector3(spawnPoint.position.x + RandomX, spawnPoint.position.y, spawnPoint.position.z), Quaternion.identity);

        hasInteracted = true;
        panelCloseTimer = 0f;
    }

    public void OpenFeatureObjectsPanel()
    {
        openClose_Panel = !openClose_Panel;
        panelCloseTimer = 0f;
    }
    public void CloseFeatureObjectsPanel()
    {
        openClose_Panel = false;
    }
}
