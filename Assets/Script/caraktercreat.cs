using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caraktercreat : MonoBehaviour
{
    public List<GantiBaju> gantiBajus = new List<GantiBaju>();

    public void randomiz()
    {
        foreach (GantiBaju changer in gantiBajus)
        {
            changer.Randomize();
        }
    }
}
