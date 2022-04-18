using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{


    private static readonly string firstplay = "firstplay";
    private static readonly string backgroundPraf = "backgroundPraf";
    private static readonly string SoundEffectPraf = "SoundEffectPraf";

    private int firstplayInt;
    public Slider backgroundSlider, soundEffectSlider;
    private float backgroundFloat, soundEffectFloat;

    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectAudio;


    // Start is called before the first frame update
    void Start()
    {
        firstplayInt = PlayerPrefs.GetInt(firstplay);

        if(firstplayInt == 0)
        {
            backgroundFloat = .125f;
            soundEffectFloat = .75f;
            backgroundSlider.value = backgroundFloat;
            soundEffectSlider.value = soundEffectFloat;
            PlayerPrefs.SetFloat(backgroundPraf, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectPraf, soundEffectFloat);
            PlayerPrefs.SetInt(firstplay, -1);



        }
        else
        {

            backgroundFloat = PlayerPrefs.GetFloat(backgroundPraf);
            backgroundSlider.value = backgroundFloat;

            soundEffectFloat = PlayerPrefs.GetFloat(SoundEffectPraf);
            soundEffectSlider.value = soundEffectFloat;

        }
    }


    public void saveSoundSetting()
    {
        PlayerPrefs.SetFloat(backgroundPraf, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectPraf, soundEffectSlider.value);
    }

    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            saveSoundSetting();
        }
    }

    public void UpdateSound()
    {
        backgroundAudio.volume = backgroundSlider.value;

        for(int i = 0; i < soundEffectAudio.Length; i++)
        {
            soundEffectAudio[i].volume = soundEffectSlider.value;
        }
    }


}
