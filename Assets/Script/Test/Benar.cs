using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Benar : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            int score = PlayerPrefs.GetInt("score") + 10;
            PlayerPrefs.SetInt("score", score);
        }

        else
        {
            int score = PlayerPrefs.GetInt("score") + 0;
            PlayerPrefs.SetInt("score", score);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
