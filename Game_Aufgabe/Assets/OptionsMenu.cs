using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour {

    public AudioMixer SetVolume; //Connected with the AudioMixer
    
	public void Volume(float v)
    {
        Debug.Log(v);
        SetVolume.SetFloat("volume", v);
    }
    public void Resolution()
    {

    }
    public void Graphics()
    {

    }
}
