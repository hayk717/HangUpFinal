using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsWin : MonoBehaviour
{
    public GameObject Settings_Win;
    public AudioSource music;
    public AudioSource sound;
    public Slider musicSlider;
    public Slider soundSlider;
    public static float music_sound;
    public static float btn_sound;

    public void OpenWindow()
    {
        Settings_Win.SetActive(true);
    }

    public void CloseWindow()
    {
        Settings_Win.SetActive(false);
    }



    private void Start()
    {
        if (PlayerPrefs.HasKey("music_volume") && PlayerPrefs.HasKey("sound_volume"))
        {
            musicSlider.value = PlayerPrefs.GetFloat("music_volume", musicSlider.value);
            soundSlider.value = PlayerPrefs.GetFloat("sound_volume", soundSlider.value);

            
        }
    }

    private void Update()
    {
        sound.volume = soundSlider.value;
        music.volume = musicSlider.value;

        PlayerPrefs.SetFloat("music_volume", musicSlider.value);
        PlayerPrefs.SetFloat("sound_volume", soundSlider.value);

        music_sound = PlayerPrefs.GetFloat("music_volume", musicSlider.value);
        btn_sound = PlayerPrefs.GetFloat("sound_volume", soundSlider.value);

    }
}
