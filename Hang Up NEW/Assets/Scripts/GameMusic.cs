using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioSource game_music;
    public AudioSource WinningMusic;
    public AudioSource btnSound;

    private void Start()
    {
        game_music.volume = SettingsWin.music_sound;
        WinningMusic.volume = PlayerPrefs.GetFloat("sound_volume", SettingsWin.btn_sound);
        btnSound.volume = PlayerPrefs.GetFloat("sound_volume", SettingsWin.btn_sound);
    }
}
