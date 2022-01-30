using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AudioManager : MonoBehaviour
{
    public GameObject musicControlButton, sfxControlButton;
    public Sprite musicOffSprite, musicOnSprite, sfxOffSprite, sfxOnSprite;

    public bool musicMuted = false;
    public bool sfxMuted = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MusicControl()
    {
        if (musicMuted == true)
        {
            musicMuted = false;
            musicControlButton.GetComponent<Image>().sprite = musicOnSprite;
            //musicControlButton.GetComponent<AudioSource>().Stop();
            musicControlButton.transform.GetChild(0).gameObject.GetComponent<AudioSource>().mute = false;
        }
        else
        {
            musicMuted = true;
            musicControlButton.GetComponent<Image>().sprite = musicOffSprite;
            //musicControlButton.GetComponent<AudioSource>().Stop();
            musicControlButton.transform.GetChild(0).gameObject.GetComponent<AudioSource>().mute = true;
            musicControlButton.transform.GetChild(0).gameObject.GetComponent<AudioSource>().mute = true;

        }
    }

    public void sfxControl()
    {
        if (sfxMuted == true)
        {
            sfxMuted = false;
            sfxControlButton.GetComponent<Image>().sprite = sfxOnSprite;
            //sfxControlButton.GetComponent<AudioSource>().PlayOneShot(sfxControlButton.GetComponent<AudioClip>());
            sfxControlButton.transform.GetChild(0).gameObject.GetComponent<AudioSource>().mute = false;

        }
        else
        {
            sfxMuted = true;
            sfxControlButton.GetComponent<Image>().sprite = sfxOffSprite;
            sfxControlButton.transform.GetChild(0).gameObject.GetComponent<AudioSource>().mute = true;

        }
    }
}