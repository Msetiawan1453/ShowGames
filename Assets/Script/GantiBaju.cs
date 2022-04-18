using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GantiBaju : MonoBehaviour
{
    [Header("sprite to change")]
    public SpriteRenderer bodypart;
  

    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

   public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 1;
        }

        bodypart.sprite = options[currentOption];

    }

    public void previousOption()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count -1;
        }

        bodypart.sprite = options[currentOption];
 
    }

    public void Randomize()
    {
        currentOption = Random.Range(1, options.Count - 1);
        bodypart.sprite = options[currentOption];
    
    }

}
