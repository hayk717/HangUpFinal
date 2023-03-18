using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeftPlayer : RightPlayer
{
    public GameObject LeftCursor;

    public void clickleft()
    {

        GameObject gobj = GameObject.FindGameObjectWithTag("LeftEllipse");
        gobj ??= defaultGobj;

        Animator anim = LeftCursor.GetComponent<Animator>();
        anim.SetTrigger("LeftStop");

        if (gobj.name == "left_ellipse")
        {
            gobj.GetComponent<Rigidbody>().AddForce(new Vector3(moveForce, moveForce, this.transform.position.z));
        }
        else 
        {
            Instantiate(leftPlayer);
            
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(leftPlayer);

        ParticleSystem particles = GameObject.FindGameObjectWithTag("ParticleLeft").GetComponent<ParticleSystem>();
        particles.Play();

        count++;

        if (count <= 5)
        {
            Image circle = circles[count].GetComponent<Image>();
            circle.sprite = black.sprite;
        }

        if (count == 5)
        {
            Image gobj = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
            gobj.enabled = true;

            Image gobj0 = GameObject.FindGameObjectWithTag("Winner_Win").GetComponent<Image>();
            gobj0.enabled = true;

            Image gobj1 = GameObject.FindGameObjectWithTag("LeftWinnerText").GetComponent<Image>();
            gobj1.enabled = true;

            Image gobj2 = GameObject.FindGameObjectWithTag("Button").GetComponent<Image>();
            gobj2.enabled = true;

            Image gobj3 = GameObject.FindGameObjectWithTag("Exit").GetComponent<Image>();
            gobj3.enabled = true;

            AudioSource music = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
            music.volume = 0f;

            AudioSource WinSound = GameObject.FindGameObjectWithTag("WinMusic").GetComponent<AudioSource>();
            WinSound.enabled = true;
        }
    }
}
