using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : RightPlayer
{
    public void restart()
    {
        SceneManager.LoadScene("_Game_Scene_");
        count = 2;

    }

    public void ToMenu()
    {
        SceneManager.LoadScene("_Menu_Scene_");
    }

    public void Play()
    {
        SceneManager.LoadScene("_Game_Scene_");
        Time.timeScale = 1f;
        count = 2;

    }
}
