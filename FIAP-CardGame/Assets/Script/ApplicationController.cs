﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void ExitGame()
    {
        Application.Quit();
    }

    //sound configuration

    //SFX
    public static void EnableSoundSFX()
    {
        PlayerPrefs.SetInt("SFXSound", 1);
    }

    public static void DisableSoundSFX()
    {
        PlayerPrefs.SetInt("SFXSound", 0);
    }

    public static bool IsMuttedSoundSFX()
    {
        if(PlayerPrefs.GetInt("SFXSound") == 1)
        {
            return true;
        }

        return false;
    }

    public static void SetVolumeSFX(float volume)
    {
        PlayerPrefs.SetFloat("SFXSoundVolume", volume);
    }

    public static float GetVolumeSFX()
    {
        return PlayerPrefs.GetFloat("SFXSoundVolume");
    }

    //Music
    public static void EnableSoundMusic()
    {
        PlayerPrefs.SetInt("MusicSound", 1);
    }

    public static void DisableSoundMusic()
    {
        PlayerPrefs.SetInt("MusicSound", 0);
    }

    public static bool IsMuttedSoundMusic()
    {
        if (PlayerPrefs.GetInt("MusicSound") == 1)
        {
            return true;
        }

        return false;
    }

    public static void SetVolumeMusic(float volume)
    {
        PlayerPrefs.SetFloat("MusicSoundVolume", volume);
    }

    public static float GetVolumeMusic()
    {
        return PlayerPrefs.GetFloat("MusicSoundVolume");
    }

    //sound configuration
}
