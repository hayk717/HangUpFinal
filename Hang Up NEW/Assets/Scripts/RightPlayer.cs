using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightPlayer : MonoBehaviour
{
    public GameObject rightPlayer;
    public GameObject defaultGobj;
    public static int count = 2;

    public GameObject[] circles = new GameObject[6];

    public Image black;
    public Image white;

    public GameObject leftPlayer;
    public int moveForce = 1000;


    public GameObject RightCursor;
    private Animator anim;


    public InterAds interAds;
    public static int counterOfAds;
    

    public void click()
    {
        GameObject gobj = GameObject.FindGameObjectWithTag("RightEllipse");
        gobj ??= defaultGobj;

        anim = RightCursor.GetComponent<Animator>();
        anim.SetTrigger("RightStop");

        if (gobj.name == "right_ellipse")
        {
            gobj.GetComponent<Rigidbody>().AddForce(new Vector3(-moveForce, moveForce, this.transform.position.z));
        }
        else 
        {
            Instantiate(rightPlayer);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(rightPlayer);

        ParticleSystem particles = GameObject.FindGameObjectWithTag("ParticleRight").GetComponent<ParticleSystem>();
        particles.Play();

        if (count >= 0)
        {
            Image image = circles[count].GetComponent<Image>();
            image.sprite = white.sprite;
        }

        if (count == 0)
        {
            Image gobj = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
            gobj.enabled = true;

            Image gobj0 = GameObject.FindGameObjectWithTag("Winner_Win").GetComponent<Image>();
            gobj0.enabled = true;

            Image gobj1 = GameObject.FindGameObjectWithTag("RightWinnerText").GetComponent<Image>();
            gobj1.enabled = true;

            Image gobj2 = GameObject.FindGameObjectWithTag("Button").GetComponent<Image>();
            gobj2.enabled = true;

            Image gobj3 = GameObject.FindGameObjectWithTag("Exit").GetComponent<Image>();
            gobj3.enabled = true;

            AudioSource music = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
            music.volume = 0f;

            AudioSource WinSound = GameObject.FindGameObjectWithTag("WinMusic").GetComponent<AudioSource>();
            WinSound.enabled = true;



            counterOfAds++;

            if (counterOfAds == 2)
            {
                interAds.ShowAd();
                counterOfAds = 0;
            }
        }

        

        count--;
    }

    private void Start()
    {
        for (int i = 0; i < circles.Length; i++)
        {
            circles[i] = GameObject.FindGameObjectWithTag(Convert.ToString(i));
        }

        
    }

}

