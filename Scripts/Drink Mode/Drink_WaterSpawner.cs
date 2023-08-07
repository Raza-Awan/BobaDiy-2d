using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink_WaterSpawner : MonoBehaviour
{
    [Header("Water Prefabs References")]
    public GameObject waterPrefab_1;
    public GameObject waterPrefab_2;
    public GameObject waterPrefab_3;

    [Header("Spawn Points References")]
    public Transform spawnPoint_1;
    public Transform spawnPoint_2;
    public Transform spawnPoint_3;

    [Header("OBJECTS TO ON OFF")]
    [Space]
    public GameObject[] objectsToOnOff;
    public GameObject pipes_Holder;
    public GameObject drink_btn;
    public GameObject gameBack_btn;

    [Space]
    public GameObject[] fruitsToSpawn;
    public Transform fruitsSpawnPoint;
    private float fruitsSpawnDelay;

    [Space]
    public float waterSpawnDelay = 0.05f;
    public float autoTimer;

    [Space]
    public bool buttonPressed_1;
    public bool buttonPressed_2;
    public bool buttonPressed_3;

    float spawnTimer;

    void Start()
    {
        fruitsSpawnDelay = autoTimer / fruitsToSpawn.Length;

        drink_btn.SetActive(false);
        gameBack_btn.SetActive(false);

        spawnTimer = waterSpawnDelay;

        buttonPressed_1 = false;
        buttonPressed_2 = false;
        buttonPressed_3 = false;

        StartCoroutine(SpawnRandomFruits());
    }

    void Update()
    {
        if (drink_btn.activeSelf == true)
        {
            gameBack_btn.SetActive(false);
        }
        if (gameBack_btn.activeSelf == true)
        {
            drink_btn.SetActive(false);
        }

        autoTimer -= Time.deltaTime;
        if (autoTimer >0)
        {
            buttonPressed_1 = true;
            buttonPressed_2 = true;
            buttonPressed_3 = true;

            foreach (GameObject obj in objectsToOnOff)
            {
                obj.SetActive(false);
            }
        }
        if (autoTimer > -1 && autoTimer < 0)
        {
            buttonPressed_1 = false;
            buttonPressed_2 = false;
            buttonPressed_3 = false;
            autoTimer = -2;

            foreach (GameObject obj in objectsToOnOff)
            {
                obj.SetActive(true);
            }

            drink_btn.SetActive(true);
            gameBack_btn.SetActive(false);
        }

        if (buttonPressed_1 == true)
        {
            SpawnWaterFromBtn_1();
        }
        if (buttonPressed_2 == true)
        {
            SpawnWaterFromBtn_2();
        }
        if (buttonPressed_3 == true)
        {
            SpawnWaterFromBtn_3();
        }
    }

    void SpawnWaterFromBtn_1() // For spawning water at pipe one position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_1, spawnPoint_1.position, Quaternion.identity);
            spawnTimer = waterSpawnDelay;
        }
    }

    void SpawnWaterFromBtn_2() // For spawning water at pipe two position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_2, spawnPoint_2.position, Quaternion.identity);
            spawnTimer = waterSpawnDelay;
        }
    }

    void SpawnWaterFromBtn_3() // For spawning water at pipe two position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_3, spawnPoint_3.position, Quaternion.identity);
            spawnTimer = waterSpawnDelay;
        }
    }

    IEnumerator SpawnRandomFruits()
    {
        foreach (GameObject obj in fruitsToSpawn)
        {
            float minX = -1.3f;
            float maxX = 1.3f;

            float RandomX = Random.Range(minX, maxX);

            Vector3 spawnPosition = new Vector3(fruitsSpawnPoint.position.x + RandomX, fruitsSpawnPoint.position.y, fruitsSpawnPoint.position.z);

            Instantiate(obj, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(fruitsSpawnDelay);
        }
    }

    // For button 1
    public void OnPointerDown_1()
    {
        buttonPressed_1 = true;
    }
    public void OnPointerUp_1()
    {
        buttonPressed_1 = false;
    }

    // For button 2
    public void OnPointerDown_2()
    {
        buttonPressed_2 = true;
    }
    public void OnPointerUp_2()
    {
        buttonPressed_2 = false;
    }

    // For button 3
    public void OnPointerDown_3()
    {
        buttonPressed_3 = true;
    }
    public void OnPointerUp_3()
    {
        buttonPressed_3 = false;
    }

    // Drink Button
    public void Drink_Btn()
    {
        pipes_Holder.SetActive(false);
        gameBack_btn.SetActive(true);
        drink_btn.SetActive(false);

        foreach (GameObject obj in objectsToOnOff)
        {
            obj.SetActive(false);
        }
    }

    public void GameBack_Btn()
    {
        pipes_Holder.SetActive(true);
        drink_btn.SetActive(true);
        gameBack_btn.SetActive(false);

        foreach (GameObject obj in objectsToOnOff)
        {
            obj.SetActive(true);
        }
    }
}
