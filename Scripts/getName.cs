using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getName : MonoBehaviour
{
    public Text nametxt;

    void Start()
    {
        nametxt.text = "Currently playing: " + Keepdata.name;
    }
}
