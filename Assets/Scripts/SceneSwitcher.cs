using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void quitGame()
    {
        Application.Quit();
    }

    
    public void switcher(int switch_to)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(switch_to);
    }

}
