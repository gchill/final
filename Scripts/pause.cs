using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject game;
    public Button Con;
    public GameObject Music;

    public int points; 
    void Start()
    {
        pauseMenu.SetActive(false);
    }
    public void Continue()
    {
        pauseMenu.SetActive(false);
        game.SetActive(true);
    }
    public void load()
    {
        points = trackGame.points;
    }
    public void newGame()
    {
        SceneManager.LoadScene("1Intro");
    }
    public void JSON()
    {
        points = trackGame.points;
        Debug.Log(points);
    }
    public void music()
    {

    }
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
           pauseMenu.SetActive(true); 
           game.SetActive(false);
        }
    }
    
}
