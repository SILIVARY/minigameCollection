using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IC : MonoBehaviour
{
    public Image TextImage;
    public Sprite TextSprite;
    public Sprite TextImage2;
    bool a = true;

    public void ChangeImage()
    {
       if (a == true)
        {
            TextImage.sprite = TextSprite;
            a = false;
        }
       else
        {
            TextImage.sprite = TextImage2;
            a = true;
        }
    }
}
