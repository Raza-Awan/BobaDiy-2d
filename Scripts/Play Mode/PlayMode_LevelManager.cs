using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMode_LevelManager : MonoBehaviour
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
        SceneManager.LoadScene("Play Selection Scene");
    }

    public void Level_1()
    {
        SceneManager.LoadScene("Play 1");
    }
    public void Level_2()
    {
        SceneManager.LoadScene("Play 2");
    }
    public void Level_3()
    {
        SceneManager.LoadScene("Play 3");
    }
    public void Level_4()
    {
        SceneManager.LoadScene("Play 4");
    }
    public void Level_5()
    {
        SceneManager.LoadScene("Play 5");
    }
    public void Level_6()
    {
        SceneManager.LoadScene("Play 6");
    }
    public void Level_7()
    {
        SceneManager.LoadScene("Play 7");
    }
    public void Level_8()
    {
        SceneManager.LoadScene("Play 8");
    }
}
