using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour
{

    // referenses to controlled game objects
    public GameObject hood, shirts, pants;

    // variable contains which avatar is on and active
    int whichAvatarIsOn = 1;

    // Use this for initialization
    void Start()
    {
      
    }

    // public method to switch avatars by pressing UI button
    public void SwitchAvatar(int type)
    {

        // processing whichAvatarIsOn variable
        switch (type)
        {

            case 1:

                // then the second avatar is on now
                whichAvatarIsOn = 3;

                // disable the first one and anable the second one
                hood.gameObject.SetActive(false);
                shirts.gameObject.SetActive(true);
                pants.gameObject.SetActive(false);
                break;

            // if the second avatar is on
            case 2:

                // then the first avatar is on now
                whichAvatarIsOn = 1;

                // disable the second one and anable the first one
                hood.gameObject.SetActive(true);
                shirts.gameObject.SetActive(false);
                pants.gameObject.SetActive(false);
                break;

            case 3:
                whichAvatarIsOn = 2;
                hood.gameObject.SetActive(false);
                shirts.gameObject.SetActive(false);
                pants.gameObject.SetActive(true);
                break;

        }


    }
}