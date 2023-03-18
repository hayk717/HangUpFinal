using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject info_win;
    private int first_enter;



    public void close_info_win()
    {
        info_win.SetActive(false);
    }

    public void open_info_win()
    {
        info_win.SetActive(true);
    }





    private void Start()
    {
        if (PlayerPrefs.HasKey("first_enter"))
        {
            first_enter = PlayerPrefs.GetInt("first_enter", first_enter);

        }

        if (first_enter == 0)
        {
            info_win.SetActive(true);
            first_enter = 1;

            PlayerPrefs.SetInt("first_enter", first_enter);


        }



    }
}