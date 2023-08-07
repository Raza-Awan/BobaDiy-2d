using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffet_WaterSpawner : MonoBehaviour
{
    public Buffet_FruitsSpawner buffet_FruitsSpawner;

    [Header("Water Prefabs References")]
    public GameObject waterPrefab_1;
    public GameObject waterPrefab_2;
    public GameObject waterPrefab_3;
    public GameObject waterPrefab_4;
    public GameObject waterPrefab_5;
    public GameObject waterPrefab_6;

    [Header("Spawn Points References")]
    public Transform spawnPoint_1;
    public Transform spawnPoint_2;
    public Transform spawnPoint_3;
    public Transform spawnPoint_4;
    public Transform spawnPoint_5;
    public Transform spawnPoint_6;

    [Space]
    public float spawnDelay = 0.2f;
    public float fillTimer;

    [Space]
    public bool buttonPressed_1;
    public bool buttonPressed_2;
    public bool buttonPressed_3;
    public bool buttonPressed_4;
    public bool buttonPressed_5;
    public bool buttonPressed_6;
    public bool fillTimerCheck;
    public bool glassFilled;

    float spawnTimer;

    void Start()
    {
        spawnTimer = spawnDelay;

        buttonPressed_1 = false;
        buttonPressed_2 = false;
        buttonPressed_3 = false;
        buttonPressed_4 = false;
        buttonPressed_5 = false;
        buttonPressed_6 = false;
        fillTimerCheck = false;
        glassFilled = false;
    }

    void Update()
    {
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
        if (buttonPressed_4 == true)
        {
            SpawnWaterFromBtn_4();
        }
        if (buttonPressed_5 == true)
        {
            SpawnWaterFromBtn_5();
        }
        if (buttonPressed_6 == true)
        {
            SpawnWaterFromBtn_6();
        }

        if (buttonPressed_1 || buttonPressed_2 || buttonPressed_3 || buttonPressed_4 || buttonPressed_5 || buttonPressed_6)
        {
            fillTimerCheck = true;
        }
        else
        {
            fillTimerCheck = false;
        }

        if (fillTimerCheck == true)
        {
            fillTimer -= Time.deltaTime;
        }
        if (fillTimer <= 0f && buffet_FruitsSpawner.showFruitsPanel_On_btn == false)
        {
            fillTimer = 0f;
            buffet_FruitsSpawner.fruitsPanel_On_btn.SetActive(true);
        }
        else
        {
            buffet_FruitsSpawner.fruitsPanel_On_btn.SetActive(false);
        }
    }

    void SpawnWaterFromBtn_1() // For spawning water at pipe one position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_1, spawnPoint_1.position, Quaternion.identity);
            spawnTimer = spawnDelay;
        }
    }

    void SpawnWaterFromBtn_2() // For spawning water at pipe two position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_2, spawnPoint_2.position, Quaternion.identity);
            spawnTimer = spawnDelay;
        }
    }

    void SpawnWaterFromBtn_3() // For spawning water at pipe two position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_3, spawnPoint_3.position, Quaternion.identity);
            spawnTimer = spawnDelay;
        }
    }

    void SpawnWaterFromBtn_4() // For spawning water at pipe two position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_4, spawnPoint_4.position, Quaternion.identity);
            spawnTimer = spawnDelay;
        }
    }

    void SpawnWaterFromBtn_5() // For spawning water at pipe two position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_5, spawnPoint_5.position, Quaternion.identity);
            spawnTimer = spawnDelay;
        }
    }

    void SpawnWaterFromBtn_6() // For spawning water at pipe two position
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            Instantiate(waterPrefab_6, spawnPoint_6.position, Quaternion.identity);
            spawnTimer = spawnDelay;
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

    // For button 4
    public void OnPointerDown_4()
    {
        buttonPressed_4 = true;
    }
    public void OnPointerUp_4()
    {
        buttonPressed_4 = false;
    }

    // For button 5
    public void OnPointerDown_5()
    {
        buttonPressed_5 = true;
    }
    public void OnPointerUp_5()
    {
        buttonPressed_5 = false;
    }

    // For button 6
    public void OnPointerDown_6()
    {
        buttonPressed_6 = true;
    }
    public void OnPointerUp_6()
    {
        buttonPressed_6 = false;
    }
}
