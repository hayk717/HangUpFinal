using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseContinue : MonoBehaviour
{
    

    public void Pause()
    {
        Image gobj = GameObject.FindGameObjectWithTag("PausePanel").GetComponent<Image>();
        gobj.enabled = true;

        Image gobj1 = GameObject.FindGameObjectWithTag("Winner_Win_Pause").GetComponent<Image>();
        gobj1.enabled = true;

        Image gobj2 = GameObject.FindGameObjectWithTag("Resume").GetComponent<Image>();
        gobj2.enabled = true;

        Image gobj3 = GameObject.FindGameObjectWithTag("ExitPause").GetComponent<Image>();
        gobj3.enabled = true;

        Image gobj4 = GameObject.FindGameObjectWithTag("PauseText").GetComponent<Image>();
        gobj4.enabled = true;

        Time.timeScale = 0;

        AudioSource music = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
        music.volume = 0f;


    }

    public void Continue()
    {
        Image gobj = GameObject.FindGameObjectWithTag("PausePanel").GetComponent<Image>();
        gobj.enabled = false;

        Image gobj1 = GameObject.FindGameObjectWithTag("Winner_Win_Pause").GetComponent<Image>();
        gobj1.enabled = false;

        Image gobj2 = GameObject.FindGameObjectWithTag("Resume").GetComponent<Image>();
        gobj2.enabled = false;

        Image gobj3 = GameObject.FindGameObjectWithTag("ExitPause").GetComponent<Image>();
        gobj3.enabled = false;

        Image gobj4 = GameObject.FindGameObjectWithTag("PauseText").GetComponent<Image>();
        gobj4.enabled = false;

        Time.timeScale = 1f;

        AudioSource music = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
        music.volume = SettingsWin.music_sound;
    }
}
