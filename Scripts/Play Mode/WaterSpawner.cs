using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    [Header("Water Prefabs References")]
    public GameObject waterPrefab_1;
    public GameObject waterPrefab_2;
    public GameObject waterPrefab_3;

    [Header("Spawn Points References")]
    public Transform spawnPoint_1;
    public Transform spawnPoint_2;
    public Transform spawnPoint_3;

    [Space]
    public float spawnDelay = 0.05f;

    [Space]
    public bool buttonPressed_1;
    public bool buttonPressed_2;
    public bool buttonPressed_3;

    float spawnTimer;

    void Start()
    {
        spawnTimer = spawnDelay;

        buttonPressed_1 = false;
        buttonPressed_2 = false;
        buttonPressed_3 = false;
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

    // For button 1
    public void OnPointerDown_1()
    {
        buttonPressed_1 = true;
        WaterPipe_Press_Sound.fillDrink_AudioSource.Play();
    }
    public void OnPointerUp_1()
    {
        buttonPressed_1 = false;
        WaterPipe_Press_Sound.fillDrink_AudioSource.Stop();
    }

    // For button 2
    public void OnPointerDown_2()
    {
        buttonPressed_2 = true;
        WaterPipe_Press_Sound.fillDrink_AudioSource.Play();
    }
    public void OnPointerUp_2()
    {
        buttonPressed_2 = false;
        WaterPipe_Press_Sound.fillDrink_AudioSource.Stop();
    }

    // For button 3
    public void OnPointerDown_3()
    {
        buttonPressed_3 = true;
        WaterPipe_Press_Sound.fillDrink_AudioSource.Play();
    }
    public void OnPointerUp_3()
    {
        buttonPressed_3 = false;
        WaterPipe_Press_Sound.fillDrink_AudioSource.Stop();
    }
}
