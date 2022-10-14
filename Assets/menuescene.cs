using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuescene : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene(3);
    }
    public void option()
    { 
        SceneManager.LoadScene(4);
    }
    public void LoadedGame()
    {
        SceneManager.LoadScene(1);
    }


}