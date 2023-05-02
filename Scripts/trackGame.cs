using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trackGame : MonoBehaviour
{
    public Text livetxt;
    public Text pointtxt;
    public Text hightxt;

    public int lives = displaylives.lives;
    public  static int points = 0;

    public void UpLives()
    {
        lives = lives + 1;
        livetxt.text = lives + " lives left";
    }
    public void Downlives()
    { 
        lives = lives - 1;
        livetxt.text = lives + " lives left";
    }
    public void UpPoints()
    {
        points = points + 1;
        pointtxt.text = points + " points";
    }
    public void Downpoints()
    {
        points = points - 1;
        pointtxt.text = points + " points";
    }
    public void reset()
    {
        hightxt.text = "scores reset";
    }
}
