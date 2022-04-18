using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSetting : MonoBehaviour
{

    private static readonly string backgroundPraf = "backgroundPraf";
    private static readonly string SoundEffectPraf = "SoundEffectPraf";
    private float backgroundFloat, soundEffectFloat;

    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectAudio;


    // Start is called before the first frame update
    void awake()
    {
        continueSetting();
    }
    private void continueSetting()
    {
        backgroundFloat = PlayerPrefs.GetFloat(backgroundPraf);
        soundEffectFloat = PlayerPrefs.GetFloat(SoundEffectPraf);

        backgroundAudio.volume = backgroundFloat;

        for (int i = 0; i < soundEffectAudio.Length; i++)
        {
            soundEffectAudio[i].volume = soundEffectFloat;
        }
    }

}
