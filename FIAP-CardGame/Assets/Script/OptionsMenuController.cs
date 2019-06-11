using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuController : MonoBehaviour
{

    public Toggle toggleSoundSFX;
    public Toggle toggleSoundMusic;
    public Slider sliderVolumeSFX;
    public Slider sliderVolumeMusic;
    
    // Start is called before the first frame update
    void Start()
    {
        toggleSoundSFX.isOn = ApplicationController.IsMuttedSoundSFX();
        toggleSoundMusic.isOn = ApplicationController.IsMuttedSoundMusic();
        sliderVolumeSFX.value = ApplicationController.GetVolumeSFX();
        sliderVolumeMusic.value = ApplicationController.GetVolumeMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
