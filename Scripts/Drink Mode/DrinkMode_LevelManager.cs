using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrinkMode_LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back_Btn()
    {
        SceneManager.LoadScene("Drink Selection Scene");
    }

    public void Level_1()
    {
        SceneManager.LoadScene("Drink 1");
    }
    public void Level_2()
    {
        SceneManager.LoadScene("Drink 2");
    }
    public void Level_3()
    {
        SceneManager.LoadScene("Drink 3");
    }
    public void Level_4()
    {
        SceneManager.LoadScene("Drink 4");
    }
    public void Level_5()
    {
        SceneManager.LoadScene("Drink 5");
    }
    public void Level_6()
    {
        SceneManager.LoadScene("Drink 6");
    }
    public void Level_7()
    {
        SceneManager.LoadScene("Drink 7");
    }
    public void Level_8()
    {
        SceneManager.LoadScene("Drink 8");
    }
}
