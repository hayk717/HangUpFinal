using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource btnClick;
    
    

    public void PlayClick() 
    {
        btnClick.Play();
    }

}
