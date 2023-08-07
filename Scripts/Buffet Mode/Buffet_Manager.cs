using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buffet_Manager : MonoBehaviour
{
    public GameObject[] pipes;
    public Transform[] ref_Positions;
    public Button[] waterSpawnButtons;
    public Transform[] buttonsRefPos;
    public Transform buttonScreenOutPos;

    public Transform screenOutPos;

    public int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button button in waterSpawnButtons)
        {
            button.gameObject.SetActive(false);
        }

        for (int i = 0; i < 3; i++)
        {
            waterSpawnButtons[i].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentIndex == 0)
        {
            pipes[0].transform.position = ref_Positions[0].position;
            pipes[1].transform.position = ref_Positions[1].position;
            pipes[2].transform.position = ref_Positions[2].position;

            foreach (Button button in waterSpawnButtons)
            {
                button.gameObject.SetActive(false);
            }

            for (int i = currentIndex; i < 3; i++)
            {
                waterSpawnButtons[i].gameObject.SetActive(true);
            }

            waterSpawnButtons[0].transform.position = buttonsRefPos[0].position;
            waterSpawnButtons[1].transform.position = buttonsRefPos[1].position;
            waterSpawnButtons[2].transform.position = buttonsRefPos[2].position;
        }

        if (currentIndex == 1)
        {
            pipes[0].transform.position = screenOutPos.position;
            pipes[1].transform.position = ref_Positions[0].position;
            pipes[2].transform.position = ref_Positions[1].position;
            pipes[3].transform.position = ref_Positions[2].position;

            foreach (Button button in waterSpawnButtons)
            {
                button.gameObject.SetActive(false);
            }

            for (int i = currentIndex; i < 4; i++)
            {
                waterSpawnButtons[i].gameObject.SetActive(true);
            }

            waterSpawnButtons[1].transform.position = buttonsRefPos[0].position;
            waterSpawnButtons[2].transform.position = buttonsRefPos[1].position;
            waterSpawnButtons[3].transform.position = buttonsRefPos[2].position;
        }

        if (currentIndex == 2)
        {
            pipes[0].transform.position = screenOutPos.position;
            pipes[1].transform.position = screenOutPos.position;
            pipes[2].transform.position = ref_Positions[0].position;
            pipes[3].transform.position = ref_Positions[1].position;
            pipes[4].transform.position = ref_Positions[2].position;

            foreach (Button button in waterSpawnButtons)
            {
                button.gameObject.SetActive(false);
            }

            for (int i = currentIndex; i < 5; i++)
            {
                waterSpawnButtons[i].gameObject.SetActive(true);
            }

            waterSpawnButtons[2].transform.position = buttonsRefPos[0].position;
            waterSpawnButtons[3].transform.position = buttonsRefPos[1].position;
            waterSpawnButtons[4].transform.position = buttonsRefPos[2].position;
        }

        if (currentIndex == 3)
        {
            pipes[0].transform.position = screenOutPos.position;
            pipes[1].transform.position = screenOutPos.position;
            pipes[2].transform.position = screenOutPos.position;
            pipes[3].transform.position = ref_Positions[0].position;
            pipes[4].transform.position = ref_Positions[1].position;
            pipes[5].transform.position = ref_Positions[2].position;

            foreach (Button button in waterSpawnButtons)
            {
                button.gameObject.SetActive(false);
            }

            for (int i = currentIndex; i < 6; i++)
            {
                waterSpawnButtons[i].gameObject.SetActive(true);
            }

            waterSpawnButtons[3].transform.position = buttonsRefPos[0].position;
            waterSpawnButtons[4].transform.position = buttonsRefPos[1].position;
            waterSpawnButtons[5].transform.position = buttonsRefPos[2].position;
        }
    }


    public void OnNextButtonPressed()
    {
        if (currentIndex >= 3)
        {
            currentIndex = 3;
        }
        else
        {
            currentIndex++;
        }
    }

    public void OnPreviousButtonPressed()
    {
        if (currentIndex <= 0)
        {
            currentIndex = 0;
        }
        else
        {
            currentIndex--;
        }
    }
}
