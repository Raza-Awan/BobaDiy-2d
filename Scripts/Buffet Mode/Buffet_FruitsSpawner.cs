using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffet_FruitsSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Reference to the prefabs of the fruits objects.
    public Transform spawnPoint;

    public GameObject glassHolder;

    [Header("OBJECTS TO ON OFF")]
    public GameObject fruitsPanel;
    public GameObject fruitsPanel_On_btn;
    public GameObject strawsPanel;
    public GameObject back_btn;
    public GameObject camera_btn;
    public GameObject next_btn;
    public GameObject previous_btn;
    public GameObject waterSpawn_Btns;
    public GameObject gameBackButton;
    public GameObject drinkButton;
    public GameObject pipeHolder;
    public GameObject glassChangeButtons;

    [Space]
    public float minX;
    public float maxX;

    [Space]
    public bool showFruitsPanel;
    public bool showFruitsPanel_On_btn;
    public bool showFruitsPanel_On_Off_btn;
    public bool isDrinking;

    // Start is called before the first frame update
    void Start()
    {
        showFruitsPanel = false;
        showFruitsPanel_On_btn = false;
        showFruitsPanel_On_Off_btn = false;
        isDrinking = false;

        fruitsPanel_On_btn.SetActive(false);
        strawsPanel.SetActive(false);
        gameBackButton.SetActive(false);
        drinkButton.SetActive(false);
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

        drinkButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        ManageFruitsPanel();
    }

    private void ManageFruitsPanel()
    {
        if (showFruitsPanel == false)
        {
            // objects to remain on at start
            glassChangeButtons.SetActive(true);
            pipeHolder.SetActive(true);
            waterSpawn_Btns.SetActive(true);
            next_btn.SetActive(true);
            previous_btn.SetActive(true);

            // objects to remain off at start
            fruitsPanel.SetActive(false);
            gameBackButton.SetActive(false);
            drinkButton.SetActive(false);

            glassHolder.transform.localScale = Vector3.one;
        }

        if (showFruitsPanel == true)
        {
            // objects to on 
            // Just Enabling Fruits Panel Here On button click

            // objects to off
            glassChangeButtons.SetActive(false);

            Vector3 scale = new Vector3(0.85f, 0.85f, 0.85f);
            glassHolder.transform.localScale = scale;
        }
    }

    public void EnableFruitsPanel()
    {
        showFruitsPanel = true;
        showFruitsPanel_On_btn = true;

        fruitsPanel.SetActive(true);
    }

    public void Drink_Btn()
    {
        // objs to on
        gameBackButton.SetActive(true);
        strawsPanel.SetActive(true);

        // objs to off
        fruitsPanel.SetActive(false);
        drinkButton.SetActive(false);
        glassChangeButtons.SetActive(false);
        pipeHolder.SetActive(false);
        waterSpawn_Btns.SetActive(false);
        next_btn.SetActive(false);
        previous_btn.SetActive(false);
        back_btn.SetActive(false);
        camera_btn.SetActive(false);

    }
    public void GameBack_btn()
    {
        // objs to on
        fruitsPanel.SetActive(true);
        drinkButton.SetActive(true);
        glassChangeButtons.SetActive(true);
        pipeHolder.SetActive(true);
        waterSpawn_Btns.SetActive(true);
        next_btn.SetActive(true);
        previous_btn.SetActive(true);
        back_btn.SetActive(true);
        camera_btn.SetActive(true);

        // objs to off
        gameBackButton.SetActive(false);
        strawsPanel.SetActive(false);
    }
}
