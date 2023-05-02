using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displaylives : MonoBehaviour
{
    public  Text livetxt;
    
    public static int lives;

    void Start()
    {
        lives = Keepdata.lives;
        livetxt.text = lives + " lives left";
    }
}
