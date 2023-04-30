using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    /// <summary>
    /// send you back to start
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene("Menu");
    }


    /// <summary>
    /// ends the program
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
