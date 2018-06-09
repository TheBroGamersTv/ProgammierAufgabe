using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour {

    public AudioMixer SetVolume; //Connected with the AudioMixer
    
	public void Volume(float volume)
    {
        Debug.Log(volume);
        SetVolume.SetFloat("volume", volume);
    }
    public void Resolution()
    {

    }
    public void FullScreen(bool IsFullScreen)//Set a bool if it should be Fullscreen or not
    {
        Screen.fullScreen = IsFullScreen;
    }
    public void Graphics(int quality)//A number for the dropdown UI to select a preset from Unity
    {
        QualitySettings.SetQualityLevel(quality);
    }
    public void InvertedMouse(bool IsInverted)//Inverts Y-Axes for the Player with a bool
    {
        PlayerContoller Player=new PlayerContoller();
        Player.Inverted(IsInverted);
        Debug.Log(IsInverted);
    }
}
