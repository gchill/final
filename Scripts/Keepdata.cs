using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Keepdata : MonoBehaviour
{
    public static string name;
    public static float slidervalue;
    public static int lives;

    public InputField namein;
    public Slider slider;
    public Dropdown dropdown;

    public void keepname()
    {
        name = namein.text;
    }
    public void getTime()
    {
        slidervalue = slider.value;
    }
    public void getlives()
    {
        lives = dropdown.value;
    }
}
