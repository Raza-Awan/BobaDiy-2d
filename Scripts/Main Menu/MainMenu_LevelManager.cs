using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play_Btn()
    {
        SceneManager.LoadScene("Play Selection Scene");
    }

    public void Drink_Btn()
    {
        SceneManager.LoadScene("Drink Selection Scene");
    }

    public void Buffet_Btn()
    {
        SceneManager.LoadScene("Buffet 1");
    }
}
