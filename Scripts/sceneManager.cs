using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sceneManager : MonoBehaviour
{
    public Button button;

    public void startGame()
    {
        SceneManager.LoadScene("2Game");
    }
    public void endgame()
    {
        SceneManager.LoadScene("3Exit");
    }
}
